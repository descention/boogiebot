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

namespace BenderBot.Common
{
    

    public delegate void ChatCB(ChatMessage que, string Username);

  


    partial class BenderCore
    {
        private ArrayList ChatMessaged = new ArrayList();
        public ArrayList ChannelList = new ArrayList();


        
        private void Handle_MessageChat(WoWReader wr)
        {
            string channel = null;
            WoWGuid fguid = null, fguid2 = null;


            byte Type = wr.ReadByte();
            UInt32 Language = wr.ReadUInt();

            fguid = new WoWGuid(wr.ReadUInt64());
            wr.ReadUInt(); // rank?

            if ((ChatType)Type == ChatType.CHANNEL)
            {
                wr.ReadUInt();
                channel = wr.ReadString();
                //pvp_rank = wr.ReadUInt();
            }            

            //if (Type == 0 || Type == 1 || Type == 5 || Type == 0x53)
            //{
                fguid2 = new WoWGuid(wr.ReadUInt64());

            //}

            UInt32 Length = wr.ReadUInt();
            string Message = wr.ReadString();
            byte afk = wr.ReadByte();


            string username = null;


            ChatMessage que = new ChatMessage();
            que.GUID = fguid;
            que.Type = (ChatType)Type;
            que.Language = (Languages) Language;
            if ((ChatType)Type == ChatType.CHANNEL)
                que.Channel = channel;
            que.Length = Length;
            que.Message = Message;
            que.AFK = afk;
            que.Date = DateTime.Now;

            if (fguid.GetOldGuid() == 0)
            {
                username = "System";
            }
            else
            {
                var obj = World.GetObject(fguid);
                if (obj != null)
                {
                    username = World.GetObject(fguid).Name;
                }
                else
                    username = channel;
            }

           
            if (username == null)
            {
                Log(LogType.Chat, 0, "Got chat msg: type: {0} lang: {1} from guid: {2} message: {3}", Type, Language, fguid, Message);
                ChatMessaged.Add(que);
                QueryName(fguid);
                return;
            }

            que.Name = username;
            Log(LogType.Chat, 0, "Got chat msg: type: {0} lang: {1} from {2}  message: {3}", Type, Language, username, Message);
            Chat(que);

            //Event(new Event(EventType.EVENT_CHAT, Time.GetTime(), que, username));
        }

        private void Handle_MOTD (WoWReader wr)
        {
            int count = wr.ReadInt();
            string message = "";

            for (int i = 0; i < count; i++)
            {
                message = string.Format("{0}\n{1}", message, wr.ReadString()) ;
            }


            ChatMessage Queue = new ChatMessage();
            Queue.GUID = null;
            Queue.Name = "MOTD";
            Queue.Language = (uint)Languages.UNIVERSAL;
            Queue.Length = (uint)message.Length;
            Queue.Message = message;
            Queue.Type = ChatType.SYSTEM;

            Chat(Queue);

            //Event(new Event(EventType.EVENT_CHAT, Time.GetTime(), Queue, "MOTD"));

        }
        
        public void SendChatMsg(ChatMessage message)
        {

            //wr.Write((UInt32)Type);
            //wr.Write((UInt32)Languages.LANG_ORCISH);
            //if ((Type == ChatMsg.CHAT_MSG_WHISPER || Type == ChatMsg.CHAT_MSG_CHANNEL) && To != "")
            //    wr.Write(To);
            //wr.Write(Message);

            //Send(wr);


            WoWWriter wr = new WoWWriter(OpCode.CMSG_MESSAGECHAT);
            wr.Write((UInt32)message.Type);
            wr.Write((UInt32) message.Language);
            if ((message.Type == ChatType.WHISPER || message.Type == ChatType.CHANNEL) && message.Name != "")
                wr.Write(message.Name);
            wr.Write(message.Message);

            Send(wr);
        }

        public void SendEmoteMsg(ChatType Type, Languages Language, string Message, string To)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_TEXT_EMOTE);
            wr.Write((UInt32)Type);
            wr.Write((UInt32)Languages.ORCISH);
            wr.Write(Message);

            Send(wr);
        }

        public void JoinChannel(string channel, string password)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_JOIN_CHANNEL);
            wr.Write((UInt32)0); // dbc id??
            wr.Write((UInt16)0); // crap as ascent put it

            wr.Write(channel);
            wr.Write((byte)0);
            //Send(wr);

            //ChannelList.Add(channel);

            //Event( new Event(EventType.EVENT_CHANNEL_JOINED, Time.GetTime(), channel) );
        }

        public void PartChannel(string channel)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_LEAVE_CHANNEL);
            wr.Write((UInt32)0);
            wr.Write(channel);
            Send(wr);

            ChannelList.Remove(channel);

            //Event(new Event(EventType.EVENT_CHANNEL_LEFT, Time.GetTime(), channel));
        }
    }
}