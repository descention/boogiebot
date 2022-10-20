using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Text.RegularExpressions;
using Data;


namespace BenderBot.Common
{
    public partial class BenderCore : IWowInterop
    {

        public BenderCore()
        {
            botEventManager = new BotEventManager();
            LoadAllMessages();
            World = new World(this);
            Player = null;
            try
            {

                DataManager.Refresh();
            }
            catch (Exception ex) { Log(LogType.Error, 0, "Exception in datamanager: {0}", ex.Message); }
        }

        public bool Ready()
        {
       

            if (Player == null)
            {
                Log(LogType.System, 0, "Player=null");
                return false;
            }

            if (!IsRunning)
            {
                Log(LogType.System, 0, "WorldServerClient not running");
                return false;
            }

            return true;
        }
		
        public IEngineInterface Engine { get; set; }
        public IMover Mover { get; set; }
        public Mover RealMover { get { return Mover as Mover; } }


        public Location CorpseLocation { get; set; }
        public uint CorpseMapId { get; set; }


        public void FireUpdatePlayer()
        {
            if (UpdatePlayer != null)
                UpdatePlayer(this, EventArgs.Empty);
        }
		
        public event EventHandler UpdatePlayer;
        public CurrentPlayer Player { get; internal set; }
        public Character LoggedInCharacter { get; private set; }

       // public List<Item> Inventory { get; private set; }

        public World World { get; private set; }
        IWorld IWowInterop.World { get { return World; } }



     

      

  

        public void Log(LogType logType, int severity, string format, params object[] parameters)
        {
			// Add your own logging here.
        }

    

      


        #region Members



     

        public void Type(string input)
        {
            throw new NotImplementedException();
        }

      


        public event EventHandler<LogEventArgs> LogRecieved;

        public event EventHandler<ChatEventArgs> ChatRecieved;

        public void Chat(ChatMessage chat)
        {
            ChatRecieved.Raise(this, new ChatEventArgs(chat));
            //if (ChatRecieved != null)
            //{
            //    ChatRecieved(this, new ChatEventArgs(chat));
            //}
        }
        
        public void SendChat(ChatMessage message)
        {
            SendChatMsg(message);
        }


      


        #endregion

        #region Members

        SettingsDictionary configuration;
        public SettingsDictionary Configuration
        {
            get
            {
                return configuration;
            }
            set
            {
                configuration = value;
                Configure(value);
            }
        }
        public string RealmName { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string CharacterName { get; set; }
        public string RealmListServer { get; set; }

        private void Configure(SettingsDictionary data)
        {
            RealmName = data["Realm"];
            Account = data["Account"].ToUpper();
            Password = data["Password"].ToUpper();
            CharacterName = data["CharacterName"];
            RealmListServer = data["RealmListServer"];
        }


        public bool Start()
        {
            World = new World(this);

            const string Address = "us.logon.worldofwarcraft.com";


            if (string.IsNullOrEmpty(RealmListServer))
            {
                RealmListServer = Address;
            }

            IPAddress RLAddr = Dns.GetHostEntry(RealmListServer).AddressList[0];

            var realms = new RealmListClient(this, Account, Password);

            if (!realms.Connect(new IPEndPoint(RLAddr, 3724)))
            {
                Log(LogType.Error, 0, "Connection failed");
                return false;

            }


            if (!realms.Logon())
            {
                Log(LogType.Error, 0, "Login failed.");
                return false;
            }

            Realm realm = realms.Realms.Find(r => string.Compare(r.Name, RealmName, true) == 0);

            if (realm == null)
            {
                Log(LogType.Error, 0, "Unable to find realm {0}.", RealmName);
                return false;
            }

            string[] address = realm.Address.Split(':');
            Log(LogType.System, 0, "Loggin into to realm {0} IP: {1} port: {2}", realm.Name, address[0], address[1]);
            IPAddress WSAddr = IPAddress.Parse(address[0]); //Dns.GetHostEntry(address[0]).AddressList[0]; // only emulators use dns
            int WSPort = Int32.Parse(address[1]);

            IPEndPoint ip = new IPEndPoint(WSAddr, WSPort);

            Connect(ip, Account, realms.K);

            while (Characters == null)
            {
                System.Threading.Thread.Sleep(500);

            }
			
            LoggedInCharacter = Characters.Find(c => string.Compare(c.Name, CharacterName, true) == 0);


            Log(LogType.Error, 0, "Logging in {0}", LoggedInCharacter.Name);
            if (LoggedInCharacter == null)
            {
                Log(LogType.Error, 0, "Unable to find character {0}.", CharacterName);
                return false;
            }

            LoginChar(LoggedInCharacter);

            Player = new CurrentPlayer(this, new WoWGuid(LoggedInCharacter.GUID), ObjectTypeId.Player, null, null);
            Player.MapId = LoggedInCharacter.MapID;
            World.zoned(Player.MapId);
            World.Players.Add(Player);


            return true;


        }

        public void Stop()
        {            
            StopThread(false);
        }

        public void Pause()
        {

        }

        public void Loop()
        {
            
        }

        #endregion
    }
}
