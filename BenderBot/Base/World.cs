using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Timers;

using Foole.Utils;
using Foole.WoW;
using IcarusBot.Core;
using IcarusBot.Core.Interfaces;
using WCell.Core;
using WCell.PacketAnalysis.Updates;
using WCell.Util.Graphics;

namespace BenderBot.Common
{
    public class NameEntry
    {
        public WoWGuid GUID;
        public string Name;
        public RaceType Race;
        public GenderType Gender;
        public UInt32 Level;
        public ClassType Class;
    }

    public class TranporterEntry : WowObject
    {
        private WoWGuid entityId;
        private WoWGuid transporterId;
        private Vector4 position;

        public WoWGuid EntityToGuid(EntityId id)
        {
            BinaryWriter bw = new BinaryWriter(new MemoryStream());
            int len = id.WritePacked(bw);
            bw.BaseStream.Position = 0;
            var wr = new WoWReader(bw.BaseStream);
            WoWGuid guid = wr.ReadPackedGuid();
            return guid;
        }


        public TranporterEntry(IWowInterop interop, WoWGuid guid, ObjectTypeId type, UInt32[] fields, IMovementBlock mb, UpdateBlock c)
            : base(interop, guid, type, fields, mb)
        {
            entityId = guid;
            transporterId = EntityToGuid(c.Movement.TransporterId);
            position = c.Movement.Position;
        }

        public WoWGuid EntityId
        {
            get { return entityId; }
            set { entityId = value; }
        }

        public WoWGuid TransporterId
        {
            get { return transporterId; }
            set { transporterId = value; }
        }

        public Vector4 Position
        {
            get { return position; }
            set { position = value; }
        }
    }

    /// <summary>Keeps track of the world. 
    /// Keeps track of all objects, 
    /// including the player as well as providing methods to move (or warp)
    /// the player and provides collision detection and pathing.
    /// </summary>
    public class World : IWorld
    {
        private uint mMapID;
        public List<WowObject> Objects{get; private set;}
        public List<Unit> Units { get; private set; }
        public List<Player> Players { get; private set; }
        public List<NameEntry> Names { get; private set; }
        public List<TranporterEntry> Portals { get; private set; }
        public BlackList BlackList { get; private set; }
        private BenderCore BenderCore;

        public EventHandler<EventArgs<Unit, SpellItem>> SpellCast;

        public World(BenderCore core)
        {
            Objects  = new List<WowObject>();
            Units = new List<Unit>();
            Players = new List<Player>();
            Names = new List<NameEntry>();
            BlackList = new BlackList();
            Portals = new List<TranporterEntry>();
            BenderCore = core;

        }


        /// <summary>Returns the current World MapID. This changes every time we zone.</summary>
        public uint getMapID()
        {
            return mMapID;
        }

        /// <summary>Updates the World (and wmo/terrain managers) that we have Zoned.</summary>
        /// <param name="mapid">The new map id</param>
        public void zoned(uint mapid)
        {
            Objects = new List<WowObject>();
            Units = new List<Unit>();
            Names = new List<NameEntry>();
            BlackList = new BlackList();
            Portals = new List<TranporterEntry>();
            mMapID = mapid;
        }

        /// <summary>Adds a player to the known world</summary>
        /// <param name="plr">Player to add.</param>
        public void AddPlayer(Player plr)
        {
            if (BenderCore.Player == null && BenderCore.LoggedInCharacter.GUID == plr.GUID.GetOldGuid())
            {
                BenderCore.Player = new CurrentPlayer(plr);
                plr = BenderCore.Player;
            }


            lock (BenderCore.World)
            {
                Players.Add(plr);
            }

            

        }

        /// <summary>Adds a new Unit to the World.</summary>
        /// <param name="o">Unit to add.</param>
        public void AddUnit(Unit u)
        {
            lock (BenderCore.World)
            {
                Units.Add(u);
            }
        }

        /// <summary>Adds a new Object to the World.</summary>
        /// <param name="o">Objects to add.</param>
        public void AddObject(WowObject o)
        {
            lock (BenderCore.World)
            {
                Objects.Add(o);
            }
        }


        /// <summary>Removes an Object from the World.</summary>
        /// <param name="guid">Guid of the objects to delete.</param>
        public void RemoveObject(WoWGuid guid)
        {
            lock (BenderCore.World)
            {

                WowObject o = GetObject(guid);

                if (o is Player)

                    Players.Remove(o as Player);

                else
                    if (o is Unit)

                        Units.Remove(o as Unit);

                    else
                        Objects.Remove(o);
            }
                    

        }


        /// <summary>Returns the Name of an Object in the World.</summary>
        /// <param name="guid">Guid of the objects to query.</param>
        public WowObject GetObject(WoWGuid guid)
        {
            lock (BenderCore.World)
            {

                WowObject o;

                o = Objects.Find(u => u.GUID == guid);
                if (o != null)
                    return o;

                o = Units.Find(u => u.GUID == guid);
                if (o != null)
                    return o;

                o = Players.Find(u => u.GUID == guid);
                if (o != null)
                    return o;

                o = Portals.Find(u => u.EntityId == guid);
                if (o != null)
                    return o;
            }


            return null;
        }

        public bool ObjectExists(WoWGuid guid)
        {
            return GetObject(guid) != null;
        }


        public string checkIfNameOnly(WoWGuid guid)
        {
            NameEntry name = Names.Find(n => n.GUID == guid);
            if (name == null)
                return null;
            else
                return name.Name;

        }

        public void AddName(NameEntry ne)
        {
            lock (BenderCore.World)
            {
                Names.Add(ne);
            }
        }

        public void AddTransporter(BenderCore core, WoWGuid guid, ObjectTypeId id, uint[] fields, MovementBlock mb, UpdateBlock c)
        {
            lock (BenderCore.World)
            {
                Portals.Add(new TranporterEntry(core, guid, id, fields, mb, c));
                BenderCore.Log(LogType.System, 0, "Adding transporter!");
            }

        }
    }
}