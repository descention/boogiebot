using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Xml;
using System.Timers;
using System.IO;
using System.Threading;

using Foole.Crypt;
using Foole.Utils;
using Foole.WoW;
using Data;
using System.Collections.Generic;


namespace BenderBot.Common
{
	
	
	// Lol.. oh my god. i hated this damn file.
	
	// Not sure this class was ever used.
    /*public class MovementClass
    {
        private List<Location> waypoints;
        private Location currentLocation;
        private Location currentWaypoint;
        private Location lastLocation;
        private Location lastWaypoint;
        private BenderCore benderCore;
        public bool Halt;
        public bool Stopped;
        private Thread movementThread;
        public MovementClass(BenderCore benderCore)
        {
            waypoints = new List<Location>();
            this.benderCore = benderCore;
            Stopped = false;
            movementThread = new Thread(MovementThread);
            movementThread.Start();
        }
        public void AddWaypoint(Location loc)
        {
            lock (waypoints)
                waypoints.Add(loc);
        }
        public void Stop()
        {
            Halt = true;
        }
        public void MovementThread()
        {
            while (!benderCore.EngineInited)
                Thread.Sleep(1000);
            currentLocation = benderCore.Player.Location;
            float dt, dx, dy;
            int cnter = 0;
            int waypointCounter = 0;
            float angle = 0.0f;
            while (true)
            {
                if (waypoints.Count <= 0 || Halt)
                {
                    Thread.Sleep(500);
                    if (Halt)
                        Stopped = true;
                    continue;
                }
                while (waypoints.Count > 0)
                {
                    lastWaypoint = currentWaypoint;
                    lock (waypoints)
                    {
                        currentWaypoint = waypoints[waypointCounter];
                        waypoints.Remove(waypoints[waypointCounter]);
                    }
                    if (lastWaypoint != null)
                    {
                        angle = lastWaypoint.CalculateAngle(currentWaypoint.X, currentWaypoint.Y);
                        if (angle != currentLocation.Orientation)
                        {
                            benderCore.Player.Location = new Location(currentLocation.X, currentLocation.Y, currentLocation.Z, angle);
                            benderCore.BuildMovePacket(OpCode.MSG_MOVE_SET_FACING, CurrentLocation.X, CurrentLocation.Y,
                                                       CurrentLocation.Z, currentLocation.Orientation, 0);
                        }
                    }
                    while (true)
                    {
                        cnter++;
                        dt = 1f/1000f;
                        dx = (float)Math.Cos(currentLocation.Orientation) * benderCore.Player.moveBlock.RunSpeed * dt;
                        dy = (float)Math.Sin(currentLocation.Orientation) * benderCore.Player.moveBlock.RunSpeed * dt;
                        currentLocation = new Location(currentLocation.X + dx, currentLocation.Y + dy,
                                                       DataManager.Terrainmanager.getZ(benderCore.World.getMapID(),
                                                                                       currentLocation.X + dx,
                                                                                       currentLocation.Y + dy),
                                                       currentLocation.Orientation);
                        if (Halt)
                        {
                            benderCore.BuildMovePacket(OpCode.MSG_MOVE_STOP, CurrentLocation.X, CurrentLocation.Y,
                                                       CurrentLocation.Z, CurrentLocation.Orientation, 0);
                            lastLocation = currentLocation;
                            cnter = 0;
                            benderCore.Player.Location = CurrentLocation;
                            Stopped = true;
                            break;
                        }
                        if (currentLocation.DistanceTo(new Location(currentWaypoint.X, currentWaypoint.Y, 0)) <= 0.01)
                        {
                            benderCore.BuildMovePacket(OpCode.MSG_MOVE_STOP, CurrentLocation.X, CurrentLocation.Y,
                                                       CurrentLocation.Z, CurrentLocation.Orientation, 0);
                            lastLocation = currentLocation;
                            cnter = 0;
                            benderCore.Player.Location = CurrentLocation;
                            break;
                        }
                        if (cnter == 503)
                        {
                            if (lastLocation != null)
                                Console.WriteLine("X: " + currentLocation.X + " - Y: " + currentLocation.Y +
                                                  " Distance from last: " + lastLocation.DistanceTo(currentLocation));
                            else
                                Console.WriteLine("X: " + currentLocation.X + " - Y: " + currentLocation.Y);
                            benderCore.BuildMovePacket(OpCode.MSG_MOVE_HEARTBEAT, CurrentLocation.X, CurrentLocation.Y,
                                                       CurrentLocation.Z, CurrentLocation.Orientation,
                                                       MovementFlags.MOVEFLAG_MOVE_FORWARD);
                            lastLocation = currentLocation;
                            cnter = 0;
                            benderCore.Player.Location = CurrentLocation;
                        }
                        Thread.Sleep(1);
                    }
                }
            }
        }

        public List<Location> Waypoints
        {
            get { return waypoints; }
            set { waypoints = value; }
        }

        public Location CurrentLocation
        {
            get { return currentLocation; }
            set { currentLocation = value; }
        }

        public Location CurrentWaypoint
        {
            get { return currentWaypoint; }
            set { currentWaypoint = value; }
        }

        public void Start()
        {
            Halt = false;
            Stopped = false;
        }
    }
    */
    
    public class MovementHop
    {
        private OpCode opcode;
        private MovementFlags flags;
        private Location position;
        private uint timeOffset;

        public MovementHop(OpCode opcode, MovementFlags flags, Location position, uint timeOffset)
        {
            this.opcode = opcode;
            this.flags = flags;
            this.position = position;
            this.timeOffset = timeOffset;
        }

        public OpCode Opcode
        {
            get { return opcode; }
            set { opcode = value; }
        }

        public MovementFlags Flags
        {
            get { return flags; }
            set { flags = value; }
        }

        public Location Position
        {
            get { return position; }
        }

        public uint TimeOffset
        {
            get { return timeOffset; }
        }
    }

    public class Mover : IMover
    {

        public static float DefaultFacingPrecision = .5F;

        public MovementFlags MovementFlags { get; set; }
        private float direction;

        public float Direction 
        {
           get { return direction; }
           private set
           {
               direction = value;
               BenderCore.Player.Location.Orientation = direction;
           }
        }

        private Location _location;
        public Location Position {
            get { return _location; }
            set 
            {
                _location = value;
                BenderCore.Player.Location = value;
            }
         }
        public Location Destination { get; private set; }
        public List<Location> Path { get; set; }
        private int _pIndex { get; set; }
        

        // The queue of movement packets to send out.
        private List<MovementHop> MovementQueue { get; set; }
        private int _qIndex { get; set; }
        private uint LastUpdate { get; set; }
        
        public Location LastPosition { get; private set; }
        
        private BenderCore BenderCore;

        private MovementClass mc;

        public Mover(BenderCore benderCore)
        {
            BenderCore = benderCore;
            mc = new MovementClass(benderCore);
        }

        public MovementStatus MovementStatus
        {
            get
            {
                if (MovementFlags == MovementFlags.MOVEFLAG_MOVE_STOP)
                    return MovementStatus.Stopped;

                return MovementStatus.Moving;
            }

        }

        private void SetFlag(MovementFlags flag)
        {
            BenderCore.Log(LogType.Movement, 5, "Setting movement flag: {0}", flag);
            MovementFlags |= flag;
        }

        private void Toggle(MovementFlags flag)
        {
            MovementFlags ^= flag;
        }

        private void UnSetFlag(MovementFlags flag)
        {
            BenderCore.Log(LogType.Movement, 5, "UnSetting movement flag: {0}", flag);
            MovementFlags &= ~flag;
        }



        public void Face(float headingInRadians, float precision)
        {
            if (headingInRadians == Direction || Math.Abs(Direction - headingInRadians) > precision)
            {
                BenderCore.BuildMovePacket(OpCode.MSG_MOVE_SET_FACING, Position.X, Position.Y, Position.Z, headingInRadians, MovementFlags);
                Direction = headingInRadians;
                //Fall();
            }
        }

        public void Face(Location location, float precision)
        {
            if (Position == null)
                Position = new Location(BenderCore.Player.MoveBlock.X, BenderCore.Player.MoveBlock.Y, BenderCore.Player.MoveBlock.Z);

            float heading = Position.CalculateAngle(location.X, location.Y);
            Face(heading, precision);
        }

        public void Face(WowObject o, float precision)
        {
            Face(o.Location, precision);
        }

        public void Move(List<Location> path)
        {
            Thread.Sleep(2000);
            Path = path;
            Destination = path[0];
            _pIndex = 0;
            BenderCore.Player.Path = path;

            //lock (mc.Waypoints)
            //    mc.Waypoints = path;
            //mc.Start();
            BuildHops();
        }

        public void Move(Location location)
        {
            Move(new List<Location> { location });
        }

        public void Fall()
        {
            BenderCore.BuildMovePacket(OpCode.MSG_MOVE_FALL_LAND, Position.X, Position.Y, Position.Z, Direction, MovementFlags);
        }

        public void Stop()
        {
/*
 * if (MovementQueue != null)
                lock (MovementQueue)
                {
                    MovementQueue = null;
                }
            mc.Stop();
            while (!mc.Stopped)
                Thread.Sleep(100);
            return;*/
            lock (MovementLock)
            {

                if (MovementQueue != null && MovementFlags != 0)
                {
                    uint timeWait = Pulse(1);
                    float dx, dy;
                    if (timeWait != 1)
                    {
                        BenderCore.Log(LogType.System, 0, "TimeOffset: {0} - TimeWait: {1} - Result: {2}",
                                       MovementQueue[_qIndex].TimeOffset, timeWait,
                                       (MovementQueue[_qIndex].TimeOffset - timeWait));
                        dx = (float) Math.Cos(Direction)*(BenderCore.Player.moveBlock.RunSpeed/1000f)*
                             (MovementQueue[_qIndex].TimeOffset - timeWait);
                        dy = (float) Math.Sin(Direction)*(BenderCore.Player.moveBlock.RunSpeed/1000f)*
                             (MovementQueue[_qIndex].TimeOffset - timeWait);
                        Position = new Location(Position.X + dx, Position.Y + dy, Position.Z, Direction);
                        BenderCore.BuildMovePacket(OpCode.MSG_MOVE_STOP, Position.X, Position.Y, Position.Z, Direction,
                                                   0, 0, 0);
                    }
                    else
                        BenderCore.BuildMovePacket(OpCode.MSG_MOVE_STOP, Position.X, Position.Y, Position.Z, Direction,
                                                   0, 0, 0);
                }
                MovementQueue = null;
            }
            MovementFlags = 0;

            BenderCore.Player.Path = new List<Location>();
            Thread.Sleep(2000);

        }

        readonly object MovementLock = new object();
        public uint Pulse(uint diff)
        {

            lock (MovementLock)
            {
                if (MovementQueue == null)
                    return 1; // Tell update thread to sleep default time.
                // Run until we hit an item that isn't ready to be run
                for (; _qIndex < MovementQueue.Count; _qIndex++)
                {
                    MovementHop hop = MovementQueue[_qIndex];

                    if (hop.TimeOffset == 0)
                    {
                        BenderCore.BuildMovePacket(hop.Opcode, hop.Position.X, hop.Position.Y, hop.Position.Z, hop.Position.Orientation, hop.Flags, 0, (int)hop.TimeOffset);
                        LastUpdate = (uint)Environment.TickCount;
                        Position = hop.Position;
                        MovementFlags = hop.Flags;
                        continue;
                    }

                    if (Environment.TickCount - LastUpdate <= hop.TimeOffset)
                    {
                        // We're not supposed to send this yet
                        // Kill the loop and let it sleep for a while
                        return hop.TimeOffset - ((uint)Environment.TickCount - LastUpdate);
                    }
                    else
                    {
                        BenderCore.BuildMovePacket(hop.Opcode, hop.Position.X, hop.Position.Y, hop.Position.Z, hop.Position.Orientation, hop.Flags, 0, (int)hop.TimeOffset);

                        Position = hop.Position;
                        Direction = hop.Position.Orientation;
                        MovementFlags = hop.Flags;

                        LastUpdate = (uint)Environment.TickCount;
                        continue;
                    }

                }
            }

            return 1; // default sleep time
        }

        private void Heartbeat(float x, float y, float z, float o)
        {
            BenderCore.BuildMovePacket(OpCode.MSG_MOVE_HEARTBEAT, x, y, z, o, MovementFlags);
        }
        private float CalculateTurnTime(float currentOrientation, float targetOrientation)
        {
            float perMS = 0.00307178f;
            float difference = targetOrientation - currentOrientation;
            return Math.Abs(difference / perMS);
        }

        private int BuildHops()
        {
            if (MovementFlags > 0)
                Stop();

            lock (MovementLock)
            {
                _qIndex = 0;
                MovementQueue = new List<MovementHop>();

                int count = 0;
                float dt, dx, dy, dist;
                Location lastPosition, expected;


                // Do we need to update our heading?
                float heading = Position.CalculateAngle(Destination.X, Destination.Y);

                if (heading != Direction)
                {

                    /*float time = CalculateTurnTime(Direction, heading);
                    MovementQueue.Add(new MovementHop((Math.Abs(heading - Direction) > Math.PI
                                           ? OpCode.MSG_MOVE_START_TURN_LEFT
                                           : OpCode.MSG_MOVE_START_TURN_RIGHT),
                                           (Math.Abs(heading - Direction) < Math.PI
                                           ? MovementFlags.MOVEFLAG_TURN_RIGHT
                                           : MovementFlags.MOVEFLAG_TURN_LEFT),
                                           new Location(Position.X, Position.Y, Position.Z, Direction),
                                           0
                                           ));
                    count++;

                    Direction = heading;
                    MovementQueue.Add(new MovementHop(OpCode.MSG_MOVE_STOP_TURN, MovementFlags.MOVEFLAG_MOVE_STOP, new Location(Position.X, Position.Y, Position.Z, heading),(uint)time ));
                    count++;
                     */
                    Direction = heading;
                    MovementQueue.Add(new MovementHop(OpCode.MSG_MOVE_SET_FACING, IcarusBot.Core.MovementFlags.MOVEFLAG_MOVE_STOP, new Location(Position.X, Position.Y, Position.Z, Direction), 0));
                    count++;
                }

                float distance = Position.DistanceTo(Destination);
                float speed = BenderCore.Player.moveBlock.RunSpeed; // Hardcoding because of errors, original: BenderCore.Player.MoveBlock.RunSpeed;
                float travel_time = (distance / speed * 1000);


                BenderCore.Log(LogType.Movement, 3, "Building hop list to: {0} - Distance: {1} Travel Time: {2}", Destination, distance, travel_time);

                MovementQueue.Add(new MovementHop(OpCode.MSG_MOVE_START_FORWARD, MovementFlags.MOVEFLAG_MOVE_FORWARD, Position, 0));
                count++;

                while (travel_time > 500)
                {
                    dt = 500 / 1000f;

                    dx = (float)Math.Cos(Direction) * speed * dt;
                    dy = (float)Math.Sin(Direction) * speed * dt;

                    dist = (float)Math.Sqrt(dx * dx + dy * dy);

                    BenderCore.Log(LogType.Movement, 3, "Hop #{0} - DX: {1} DY: {2} Distance: {3}", count, dx, dy, dist);

                    lastPosition = MovementQueue[count - 1].Position;

                    expected = new Location(lastPosition.X + dx, lastPosition.Y + dy, Position.Z, Direction);

                    MovementQueue.Add(new MovementHop(OpCode.MSG_MOVE_HEARTBEAT, MovementFlags.MOVEFLAG_MOVE_FORWARD, expected, 500));
                    count++;

                    travel_time -= 500;
                }

                dt = travel_time / 1000f;

                dx = (float)Math.Cos(Direction) * (BenderCore.Player.moveBlock.RunSpeed / 1000f) * travel_time;
                dy = (float)Math.Sin(Direction) * (BenderCore.Player.moveBlock.RunSpeed / 1000f) * travel_time;

                dist = (float)Math.Sqrt(dx * dx + dy * dy);

                lastPosition = MovementQueue[count - 1].Position;

                expected = new Location(lastPosition.X + dx, lastPosition.Y + dy, Position.Z, Direction);

                BenderCore.Log(LogType.Movement, 3, "Last hop - Time left: {0} Last Position: {1} Distance: {2}", travel_time, expected, dist);

                MovementQueue.Add(new MovementHop(OpCode.MSG_MOVE_STOP, MovementFlags.MOVEFLAG_MOVE_STOP, expected, (uint)travel_time));
            }

            return MovementQueue.Count;
        }
    }


    // Movement Packet Handling
    partial class BenderCore
    {

        //public Mover Mover { get; private set; }
        private int _lastTimestamp = 0;
        private int _realTimestamp = 0;




        private void TeleportHandler(WoWReader wr)
        {
            float x, y, z, orient;
            byte mask = wr.ReadByte();

            WoWGuid guid = new WoWGuid(mask, wr.ReadBytes(WoWGuid.BitCount8(mask)));

            wr.ReadUInt(); // flags
            
            wr.ReadUInt(); // time?
            wr.ReadByte(); // unk 2.3.0

            wr.ReadSingle(); // unk2
            x = wr.ReadSingle();
            y = wr.ReadSingle();
            z = wr.ReadSingle();
            orient = wr.ReadSingle();
            wr.ReadUInt16(); // unk3
            wr.ReadByte(); // unk4
            Log(LogType.SystemDebug, 0, "Got teleport to: {0} {1} {2} {3}", x, y, z, orient);

            Player.Location = new Location(x, y, z, orient);

            WoWWriter ww = new WoWWriter(OpCode.MSG_MOVE_TELEPORT_ACK);
            ww.Write(Player.GUID.GetOldGuid());
            Send(ww);
        }

        public void SendActiveMover(Unit mover)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_SET_ACTIVE_MOVER);
            wr.Write(mover.GUID.GetOldGuid());
            Send(wr);
            Log(LogType.NeworkComms, 3, "Setting active mover {0} {1}", mover.Name, mover.GUID);
        }

        public void SendZone()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_ZONEUPDATE);
            wr.Write(LoggedInCharacter.ZoneID);
            Send(wr);
        }

        public void BuildMoveTimeSkipped(int time)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_MOVE_TIME_SKIPPED);
            wr.Write(LoggedInCharacter.GUID);
            wr.Write(time);

            Send(wr);

        }

        public void BuildMovePacket(OpCode op, float x, float y, float z, float o, MovementFlags flags)
        {
            BuildMovePacket(op, x, y, z, o, flags, 0, 0);
        }

        public void BuildMovePacket(OpCode op, float x, float y, float z, float o, MovementFlags flags, int UnkFlags, int addedTime)
        {

            // Figure out timestamp
            int timestamp;
            if (_realTimestamp == 0)
                _realTimestamp = Environment.TickCount;


            if (addedTime != 0)
            {
                timestamp = _lastTimestamp + addedTime;
            }
            else
            {
                timestamp = Environment.TickCount;
            }


            int realdiff = Environment.TickCount - _realTimestamp;




            float testZ = 0.0f;
            // Do any Z correction needed.
            //testZ = DataManager.Terrainmanager.getZ(World.getMapID(), x, y);
//            if (op != OpCode.MSG_MOVE_FALL_LAND)
//            {
                try
                {
                    testZ = DataManager.Terrainmanager.getZ(World.getMapID(), x, y);
                }
                catch (Exception)
                {
                }
            //z = testZ;
                //Log(LogType.Movement,3, "testZ = {0} currentZ = {1}", testZ, z);

                //if (testZ != 0.0f)
                 //   z = testZ;
//            }

            Log(LogType.Movement, 0, "Opcode: {5} Timestamp: {0}, LastStamp {1}, Diff: {2} Real Diff: {3} Flags: {4}", timestamp, _lastTimestamp, (timestamp - _lastTimestamp), realdiff, flags, op);
            Log(LogType.Movement, 5, "X: {0} Y: {1} Z: {2} O: {3}", x, y, z, o);


            _lastTimestamp = timestamp;
            _realTimestamp = Environment.TickCount;

            // Build zee packet
            WoWWriter ww = new WoWWriter(op);
            ww.Write(Player.GUID.PackedGuid());
            ww.Write((uint)flags);
            ww.Write((short)0);

            ww.Write(timestamp);

            ww.Write(x);
            ww.Write(y);
            ww.Write(z);
            ww.Write(o);

            ww.Write((uint)0);


            // Send zee packet
            Send(ww);
        }



        private void MonsterMovementHandler(WoWReader wr)
        {
            WoWGuid guid = wr.ReadPackedGuid();
            WowObject target = World.GetObject(guid);
            SplinePath path = new SplinePath();

            wr.ReadByte();


            Location position = wr.ReadLocation(false);

            uint systemtime = wr.ReadUInt();

            MonsterMoveType moveType = (MonsterMoveType) wr.ReadByte();



            switch (moveType)
            {
                case MonsterMoveType.Normal:
                    break;
                case MonsterMoveType.Stop:
                    {
                        if (target != null)
                        {
                            Log(LogType.Movement, 9, "Updating Locations for object {0}, Position: {1}", target.Name, position);
                            lock (target)
                            {
                                target.Location = position;
                            }
                        }
                        return;
                    }
                case MonsterMoveType.FinalFacingPoint:
                {
                    Log(LogType.SystemDebug, 0, "Final position for object: {0} Position: {1}", guid, position);
                    position = wr.ReadLocation(false);
                    break;
                }
                case MonsterMoveType.FinalFacingGuid:
                {
                    WoWGuid facing_guid = wr.ReadUnpackedGuid();
                   Log(LogType.SystemDebug, 0, "Final facing guid: {0} Position: {1}", guid, facing_guid);
                    break;
                }
                case MonsterMoveType.FinalFacingAngle:
                {
                    position.Orientation = wr.ReadFloat();
                    break;
                }
            }

            MonsterMoveFlags moveFlags = (MonsterMoveFlags) wr.ReadUInt();

            if (moveFlags.Has(MonsterMoveFlags.Flag_0x200000))
            {
                // TODO: what does this flag mean?
                wr.ReadByte();
                wr.ReadUInt();
            }

            uint waypoint_time = wr.ReadUInt();

            if (moveFlags.Has(MonsterMoveFlags.Flag_0x800))
            {

                // ToDo: figure this out
                wr.ReadFloat();
                wr.ReadUInt();
            }

            uint waypoint_count = wr.ReadUInt();
            Location[] waypoints = new Location[waypoint_count];
            
            Log(LogType.SystemDebug, 0, "MONSTER_MOVE DEBUG: GUID: {0} MoveType: {1} MovementFlags: {2} Position: {3} Spline Count: {4} Spline Time: {5}", guid, moveType, moveFlags, position, waypoint_count, waypoint_time);




            if (moveFlags.Has(MonsterMoveFlags.Flag_0x2000_FullPoints_1 | MonsterMoveFlags.Flag_0x40000_FullPoints_2))
            {
                Log(LogType.SystemDebug, 5, "Got spline count: {0} for object: {1} in MONSTER_MOVE", waypoint_count, guid);
                for (int i = 0; i < waypoint_count; i++)
                {
                    waypoints[i] = wr.ReadLocation(false);
                    Log(LogType.SystemDebug, 5, "Spline Location: {0}", waypoints[i]);
                }
            }
            else
            {
                waypoints[0] = wr.ReadLocation(false);

                Log(LogType.SystemDebug, 5, "Packed Spline Location: {0} Distance from Origin: {1}", waypoints[0], position.DistanceTo(waypoints[0]));

                for (int i = 1; i < waypoint_count; i++)
                {
                    int packed = wr.ReadInt();

                    float offsetX = (float)((packed & 0x7FF) << 21 >> 21) * 0.25f; 
                    float offsetY = (float)((((packed >> 11) & 0x7FF) << 21) >> 21) * 0.25f; 
                    float offsetZ = (float)((packed >> 22 << 22) >> 22) * 0.25f;

                    waypoints[i] = new Location(waypoints[0].X + offsetX,
                                                waypoints[0].Y + offsetY,
                                                waypoints[0].Z + offsetZ);

                    Log(LogType.SystemDebug, 5, "Packed Spline Location: {0} Distance from Origin: {1}", waypoints[i], position.DistanceTo(waypoints[i]));
                }
            }

            // If movetime is 0, we're already there! set position and don't build a path
            if (waypoint_time == 0)
            {
                position.X = waypoints[0].X;
                position.Y = waypoints[0].Y;
                position.Z = waypoints[0].Z;
            }
            else
            {
                // Else build a path and give it to the Unit

                path = new SplinePath();
                path.Waypoints = new List<Location>();

                for (int i = (int)waypoint_count - 1; i >= 0; i--)
                {
                    path.Waypoints.Add(waypoints[i]);
                }
                path.StartTime = (uint)Environment.TickCount;
                path.RunTime = waypoint_time;
            }

            if (target != null)
            {
                Log(LogType.Movement, 9, "Updating Locations for object {0}, Position: {1}", target.Name, position);
                lock (target)
                {
                    target.Location = position;
                }

                if (path.RunTime > 0)
                {
                    Log(LogType.SystemDebug, 0, "Adding path to Unit {0} - Waypoint count: {1} - Travel Time: {2}", target.Name, path.Waypoints.Count, path.RunTime);
                    Unit u = target as Unit;
                    if (u != null)
                    {
                        //u.Path = path;
                    }
                }

            }
        }

        private void MovementHandler(WoWReader wr)
        {
            WoWGuid guid = wr.ReadPackedGuid();
            MovementBlock mmb = new MovementBlock(this, ref wr, 0x20);
            WowObject target = World.GetObject(guid);
            if ( target != null)
            {
                Log(LogType.Movement, 9, "Updating Locations for object {0}, x={1} y={2} z={3} o={4}", target.Name, mmb.X, mmb.Y, mmb.Z, mmb.Facing);
                lock (target)
                {
                    target.Location = new Location(mmb.X, mmb.Y, mmb.Z, mmb.Facing);
                }
            }
        }
    }

    public class MovementBlock : IMovementBlock
    {
        BenderCore BenderCore { get; set; }
        public MovementFlags Flags { get; set; }
        public float RunSpeed { get; set; }
        public float FlySpeed { get; set; }

        UInt32 flags2{ get; set;}


        public float X { get { return posX; } }
        public float Y { get { return posY; } }
        public float Z { get { return posZ; } }
        public float Facing { get { return facing; } }


        public UInt32 unk3;
        public float posX = 0, posY = 0, posZ = 0, facing = 0;
        public float walkSpeed,  backWalkSpeed, swimSpeed, backSwimSpeed, turnRate = 0;
        public UInt16 unk_flags;

        public MovementBlock(BenderCore benderCore)
        {
            BenderCore = benderCore;
            flags2 = 0;
        }
        public MovementBlock(BenderCore benderCore,ref WoWReader wr, UInt16 flags) : this(benderCore)
        {
            if ((flags & 0x20) >= 1)
            {
#if MOVE_DEBUG
                Log(LogType.NeworkComms,5, "(flags & 20)");
#endif
                flags2 = wr.ReadUInt();

                unk_flags = wr.ReadUInt16(); // 3.0.8

                unk3 = wr.ReadUInt(); // time
#if MOVE_DEBUG
                Log(LogType.NeworkComms, 5, "flags2 = {0} - time = {1}", flags2, unk3);
#endif

                posX = wr.ReadSingle();
                posY = wr.ReadSingle();
                posZ = wr.ReadSingle();
                facing = wr.ReadSingle();
#if MOVE_DEBUG
                Log(LogType.NeworkComms, 5, "Position - X: {0} Y: {1} Z: {2} Orient: {3} ", posX, posY, posZ, facing);
#endif

                /*if ((flags2 & 0x00000200) >= 1)	// player being transported
                {
#if MOVE_DEBUG
                    Log(LogType.NeworkComms, 5, "(flags2 & 0x00000200)");
#endif

                    wr.ReadUInt64();	//guid
                    wr.ReadSingle();	//x
                    wr.ReadSingle();	//y
                    wr.ReadSingle();	//y
                    wr.ReadSingle();	//o
                    wr.ReadUInt();    // transport time
                    wr.ReadByte(); // unk 3.0.8
                }*/
                
                if ((flags2 & 0x02200000) >= 1 || (unk_flags & 0x20) >= 1)
                {
                    wr.ReadFloat(); // swim/fly pitch
                }

                wr.ReadSingle(); // fall time

                if ((flags2 & 0x00001000) >= 1)
                {
#if MOVE_DEBUG
                    Log(LogType.NeworkComms, 5, "(flags2 & 0x00001000)");
#endif
                    wr.ReadFloat(); // unk 2.3.0
                    wr.ReadFloat();
                    wr.ReadFloat();
                    wr.ReadFloat();
                }

                if ((flags2 & 0x04000000) >= 1)
                {
#if MOVE_DEBUG
                    Log(LogType.NeworkComms, 5, "flags2 & 04000000");
#endif
                    wr.ReadFloat();
                }

                walkSpeed = wr.ReadSingle();
                RunSpeed = wr.ReadSingle();
                backWalkSpeed = wr.ReadSingle();
                swimSpeed = wr.ReadSingle();
                backSwimSpeed = wr.ReadSingle();
                wr.ReadSingle(); //unk1 // fly speed
                wr.ReadSingle(); //unk2 // fly backwards speed
                turnRate = wr.ReadSingle();
                wr.ReadSingle(); // 3.0.8



                if ((flags2 & 0x08000000) >= 1)
                {
#if MOVE_DEBUG
                    Log(LogType.NeworkComms, 5, "(flags2 & 0x08000000)");
#endif
                    UInt32 splineFlags = wr.ReadUInt();

                    if ((splineFlags & 0x20000) >= 1)
                    {
                        wr.ReadSingle(); // Final facing?
                    }
                    else
                    {

                        if ((splineFlags & 0x10000) >= 1)
                        {
#if MOVE_DEBUG
                            Log(LogType.NeworkComms, 5, "(splineFlags & 0x10000)");
#endif
                            wr.ReadUInt64(); // final facing guid?
                        }

                        if ((splineFlags & 0x8000) >= 1)
                        {
#if MOVE_DEBUG
                            Log(LogType.NeworkComms, 5, "(splineFlags & 0x8000)");
#endif
                            posX = wr.ReadSingle();
                            posY = wr.ReadSingle();
                            posZ = wr.ReadSingle();
#if MOVE_DEBUG
                            Log(LogType.NeworkComms, 5, "Position 3 - X: {0} Y: {1} Z: {2} Orient: {3} ", posX, posY, posZ, facing);
#endif
                        }
                    }

                    UInt32 time1, time2, splineCount, unk4;

                    //1.8
                    time1 = wr.ReadUInt();
                    time2 = wr.ReadUInt();
                    unk4 = wr.ReadUInt();
                    wr.ReadSingle(); // 3.1 unk1
                    wr.ReadSingle(); // 3.1 unk2
                    wr.ReadSingle(); // 3.1 unk3
                    wr.ReadUInt(); // 3.1 unk4
                    splineCount = wr.ReadUInt();
#if MOVE_DEBUG
                    Log(LogType.NeworkComms, 5, "splineCount = {0}, Time1 = {1}, Time2 = {2}", splineCount, time1, time2);
#endif

                    for (UInt32 j = 0; j < splineCount; ++j)
                    {

                        posX = wr.ReadSingle();
                        posY = wr.ReadSingle();
                        posZ = wr.ReadSingle();
#if MOVE_DEBUG
                        Log(LogType.NeworkComms,5, "Position 4 - X: {0} Y: {1} Z: {2} Orient: {3} ", posX, posY, posZ, facing);
#endif
                    }

                    wr.ReadByte();
                    
                    posX = wr.ReadSingle();
                    posY = wr.ReadSingle();
                    posZ = wr.ReadSingle();
#if MOVE_DEBUG
                    Log(LogType.NeworkComms,5, "Position 5 - X: {0} Y: {1} Z: {2} -- END SPLINE", posX, posY, posZ);
#endif
                }
            }


            else if ((flags & 0x100) >= 1)
            {
                // transport apparently -
                wr.ReadPackedGuid();

                // object Pos
                posX = wr.ReadSingle();
                posY = wr.ReadSingle();
                posZ = wr.ReadSingle();

                // Transport pos
                wr.ReadSingle();
                wr.ReadSingle();
                wr.ReadSingle();

                // Orientations
                wr.ReadSingle();
                wr.ReadSingle();
            }
            else if ((flags & 0x40) >= 1)
            {

#if MOVE_DEBUG
                Log(LogType.NeworkComms, 5, "(flags & 40)");
#endif
                posX = wr.ReadSingle();
                posY = wr.ReadSingle();
                posZ = wr.ReadSingle();
                facing = wr.ReadSingle();
#if MOVE_DEBUG
                Log(LogType.NeworkComms, 5, "Position - X: {0} Y: {1} Z: {2} Orient: {3} ", posX, posY, posZ, facing);
#endif
            }


            if ((flags & 0x8) >= 1)
            {
#if MOVE_DEBUG
                Log(LogType.NeworkComms, 5, "(flags & 8)");
#endif
                wr.ReadUInt();

            }

            if ((flags & 0x10) >= 1)
            {
#if MOVE_DEBUG
                Log(LogType.NeworkComms, 5, "(flags & 10)");
#endif
                wr.ReadUInt();
            }

            if ((flags & 0x4) >= 1)
            {
#if MOVE_DEBUG
                Log(LogType.NeworkComms, 5, "(flags & 0x4) -- PACKED GUID!!");
#endif

                byte mask = wr.ReadByte();

                if (mask != 0x00)
                    new WoWGuid(mask, wr.ReadBytes(WoWGuid.BitCount8(mask)));

            }

            if ((flags & 0x2) >= 1)
            {
#if MOVE_DEBUG
                Log(LogType.NeworkComms, 5, "(flags & 0x2)");
#endif
                wr.ReadUInt();
            }

            if ((flags & 0x80) >= 1)
            {
#if MOVE_DEBUG
                Log(LogType.NeworkComms, 5, "(flags & 0x80)");
#endif
                wr.ReadInt();
                wr.ReadInt();
            }

            if ((flags & 0x200) >= 1)
            {
                wr.ReadUInt64(); // packed rotation? (gameobject_rotation)
            }
        }

        public WCell.PacketAnalysis.Updates.MovementBlock OtherMovementBlock { get; set; }
        public MovementBlock(BenderCore core, WCell.PacketAnalysis.Updates.MovementBlock movement)
        {
            BenderCore = core;
            posX = movement.Position.X;
            posY = movement.Position.Y;
            posZ = movement.Position.Z;
            facing = movement.Position.W;
            Flags = (MovementFlags)movement.MovementFlags;
            flags2 = (uint)movement.MovementFlags2;
            FlySpeed = movement.Speeds.Fly;
            RunSpeed = movement.Speeds.Run;
            OtherMovementBlock = movement;
        }
    }

    public class MovementInfo
    {
        public UInt32 time;

        public UInt32 unk8, unk9, unk10, unk11, unk12;
        public UInt32 unklast;
        public float unk6;
        public float x, y, z, orientation;
        public UInt32 flags;
        public UInt32 FallTime;
        public UInt64 transGuid;
        public float transX, transY, transZ, transO;

        public Location Location()
        {
            return new Location(x, y, z, orientation);
        }

        public MovementInfo(WoWReader wr)
        {
            WoWGuid transGuid = null;
            flags = wr.ReadUInt();
            MovementFlags newflags = (MovementFlags)flags;
            wr.ReadUInt16(); // unk
            time = wr.ReadUInt();

            x = wr.ReadFloat();
            y = wr.ReadFloat();
            z = wr.ReadFloat();
            orientation = wr.ReadFloat();

            if ((flags & 0x200) >= 1) // Transport
            {
                transGuid = wr.ReadPackedGuid();

                transX = wr.ReadFloat();
                transY = wr.ReadFloat();
                transZ = wr.ReadFloat();
                transO = wr.ReadFloat();
                wr.ReadUInt();
                wr.ReadByte();
            }

            if ((flags & 0x200000) >= 1) // Swimming
            {
                unk6 = wr.ReadFloat();
            }

            FallTime = wr.ReadUInt();
            if ((flags & 0x1000) >= 1) // Falling
            {
                wr.ReadFloat();
                wr.ReadFloat();
                wr.ReadFloat();
                wr.ReadFloat();
            }

            if ((flags & 0x4000000) >= 1)
            {
                //unk12 = wr.ReadFloat();
            }

            if (wr.Remaining >= 4) unklast = wr.ReadUInt();

        }



    
    }


}
