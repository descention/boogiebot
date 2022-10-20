using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Foole.WoW;

namespace BenderBot.Common
{

    // Protocol Switch
    public partial class BenderCore
    {
        protected Dictionary<OpCode, Action<WoWReader>> handlers = new Dictionary<OpCode, Action<WoWReader>>();
        private bool initial_packets = true;

        #region IWowInterop Members

        public bool EngineInited { get; set; }

        #endregion

        protected void AddMulti(List<OpCode> codes, Action<WoWReader> action)
        {
            foreach (OpCode code in codes)
            {
                handlers.Add(code, action);
            }
        }

        protected void SendInitPackets()
        {
            var ww = new WoWWriter(OpCode.CMSG_PLAYED_TIME);
            ww.Write((byte) 0);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_NAME_QUERY);
            ww.Write(LoggedInCharacter.GUID);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_SET_ACTIVE_MOVER);
            ww.Write(LoggedInCharacter.GUID);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_SET_ACTIONBAR_TOGGLES);
            ww.Write((byte) 0);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_REQUEST_RAID_INFO);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_GMTICKET_GETTICKET);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_QUERY_TIME);
            Send(ww);

            ww = new WoWWriter(OpCode.MSG_QUERY_NEXT_MAIL_TIME);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_BATTLEFIELD_STATUS);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_MEETINGSTONE_INFO);
            Send(ww);

            ww = new WoWWriter(OpCode.MSG_GUILD_BANK_MONEY_WITHDRAWN);
            Send(ww);

            ww = new WoWWriter(OpCode.SMSG_CALENDAR_EVENT_RESERVED_2);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_VOICE_SESSION_ENABLE);
            ww.Write((short) 0);
            Send(ww);
        }

        protected void SendMovementInit()
        {
            if (!EngineInited)
                SendInitPackets();
            BuildMovePacket(OpCode.MSG_MOVE_FALL_LAND, RealMover.Position.X, RealMover.Position.Y, RealMover.Position.Z,
                            RealMover.Position.Orientation, 0);
            SendZone();
            EngineInited = true;
        }


        protected void LoadAllMessages()
        {
            EngineInited = false;

            handlers.Add(OpCode.SMSG_FORCE_RUN_SPEED_CHANGE, Handle_ForceRunSpeedChange);
            handlers.Add(OpCode.SMSG_FORCE_FLIGHT_SPEED_CHANGE, Handle_ForceFlightSpeedChange);
            handlers.Add(OpCode.SMSG_MOVE_SET_CAN_FLY, Handle_CanFly);
            handlers.Add(OpCode.SMSG_MOVE_UNSET_CAN_FLY, Handle_UnsetCanFly);
            handlers.Add(OpCode.SMSG_ITEM_PUSH_RESULT, Handle_ItemPush);

            handlers.Add(OpCode.SMSG_SELL_ITEM, Handle_SellItem);
            handlers.Add(OpCode.SMSG_ITEM_COOLDOWN, Handle_ItemCoolDown);
            handlers.Add(OpCode.SMSG_GUILD_DECLINE, Handle_GuildDecline);
            handlers.Add(OpCode.SMSG_GUILD_INVITE, Handle_GuildInvite);
            handlers.Add(OpCode.SMSG_GROUP_LIST, Handle_GroupList);
            handlers.Add(OpCode.SMSG_GROUP_DESTROYED, Handle_GroupDestroyed);
            handlers.Add(OpCode.SMSG_GROUP_SET_LEADER, Handle_GroupSetLeader);
            handlers.Add(OpCode.SMSG_GROUP_UNINVITE, Handle_GroupUnInvite);
            handlers.Add(OpCode.SMSG_GROUP_DECLINE, Handle_GroupDecline);
            handlers.Add(OpCode.SMSG_GROUP_INVITE, Handle_GroupInvite);
            handlers.Add(OpCode.SMSG_QUEST_QUERY_RESPONSE, Handle_QuestQueryResponse);
            handlers.Add(OpCode.SMSG_PET_NAME_QUERY_RESPONSE, Handle_PetNameQueryResponse);
            handlers.Add(OpCode.SMSG_BUY_FAILED, Handle_BuyFailed);
            handlers.Add(OpCode.SMSG_BUY_ITEM, Handle_BuyItem);
            handlers.Add(OpCode.SMSG_DEATH_RELEASE_LOC, Handle_DeathReleaseLocation);
            handlers.Add(OpCode.SMSG_RESURRECT_FAILED, Handle_ResurrectFailed);
            handlers.Add(OpCode.SMSG_CORPSE_RECLAIM_DELAY, Handle_ReClaimDelay);
            handlers.Add(OpCode.MSG_CORPSE_QUERY, Handle_CorpseQuery);
            handlers.Add(OpCode.SMSG_QUESTGIVER_STATUS, Handle_QuestGiverStatus);
            handlers.Add(OpCode.SMSG_QUESTGIVER_QUEST_LIST, Handle_QuestGiverQuestList);
            handlers.Add(OpCode.SMSG_QUESTGIVER_QUEST_DETAILS, Handle_QuestGiverQuestDetails);
            handlers.Add(OpCode.SMSG_QUESTGIVER_REQUEST_ITEMS, Handle_QuestGiverRequestItems);
            handlers.Add(OpCode.SMSG_QUESTGIVER_OFFER_REWARD, Handle_QuestGiverOfferReward);
            handlers.Add(OpCode.SMSG_QUESTGIVER_QUEST_INVALID, Handle_QuestgGiverQuestInvalid);
            handlers.Add(OpCode.SMSG_QUESTGIVER_QUEST_COMPLETE, Handle_QuestGiverQuestComplete);
            handlers.Add(OpCode.SMSG_QUESTGIVER_QUEST_FAILED, Handle_QuestGiverQuestFailed);
            handlers.Add(OpCode.SMSG_QUESTLOG_FULL, Handle_QuestLogFull);
            handlers.Add(OpCode.SMSG_QUESTUPDATE_FAILED, Handle_QuestUpdateFailed);
            handlers.Add(OpCode.SMSG_QUESTUPDATE_FAILEDTIMER, Handle_QuestUpdateFailedTimer);
            handlers.Add(OpCode.SMSG_QUESTUPDATE_COMPLETE, Handle_QuestUpdateComplete);
            handlers.Add(OpCode.SMSG_QUESTUPDATE_ADD_KILL, Handle_QuestUpdateAddKill);
            handlers.Add(OpCode.SMSG_QUESTUPDATE_ADD_ITEM, Handle_QuestUpdateAddItem);
            handlers.Add(OpCode.SMSG_QUEST_CONFIRM_ACCEPT, Handle_QuestConfirmAccept);
            handlers.Add(OpCode.SMSG_SEND_MAIL_RESULT, Handle_SendMailResult);
            handlers.Add(OpCode.SMSG_MAIL_LIST_RESULT, Handle_MailListResult);
            //handlers.Add(OpCode.MSG_AUCTION_HELLO, Handle_AuctionHello);
            handlers.Add(OpCode.SMSG_AUCTION_COMMAND_RESULT, Handle_AuctionCommandResult);
            //handlers.Add(OpCode.SMSG_AUCTION_LIST_RESULT, Handle_AuctionListResult);
            //handlers.Add(OpCode.SMSG_AUCTION_OWNER_LIST_RESULT, Handle_AuctionOwnerListResult);
            //handlers.Add(OpCode.SMSG_AUCTION_BIDDER_NOTIFICATION, Handle_AuctionBidderNotification);
            // handlers.Add(OpCode.SMSG_AUCTION_BIDDER_LIST_RESULT, Handle_AuctionListResult);
            handlers.Add(OpCode.SMSG_TRAINER_LIST, Handle_TrainerList);
            handlers.Add(OpCode.SMSG_TRAINER_BUY_FAILED, Handle_TrainerBuyFailed);
            handlers.Add(OpCode.SMSG_TRAINER_BUY_SUCCEEDED, Handle_TrainerBuySucceeded);
            handlers.Add(OpCode.SMSG_AUTH_CHALLENGE, Handle_AuthRequest);
            handlers.Add(OpCode.SMSG_AUTH_RESPONSE, Handle_AuthResponse);
            handlers.Add(OpCode.SMSG_NAME_QUERY_RESPONSE, Handle_NameQuery);
            handlers.Add(OpCode.SMSG_CREATURE_QUERY_RESPONSE, Handle_CreatureQuery);
            handlers.Add(OpCode.SMSG_GAMEOBJECT_QUERY_RESPONSE, Handle_GameObjectQuery);
            handlers.Add(OpCode.SMSG_INIT_WORLD_STATES, Handle_InitWorldStates);
            handlers.Add(OpCode.SMSG_INITIAL_SPELLS, Handle_InitialSpells);
            handlers.Add(OpCode.SMSG_LEARNED_SPELL, Handle_LearntSpell);
            handlers.Add(OpCode.SMSG_SUPERCEDED_SPELL, Handle_SupercededSpell);
            handlers.Add(OpCode.SMSG_INITIALIZE_FACTIONS, Handle_InitializeFactions);
            handlers.Add(OpCode.SMSG_LOGIN_SETTIMESPEED, Handle_LoginSetTimeSpeed);
            handlers.Add(OpCode.SMSG_SPELLLOGEXECUTE, Handle_SpellLogExecute);
            handlers.Add(OpCode.SMSG_PARTY_MEMBER_STATS, Handle_GroupStatPacket);
            handlers.Add(OpCode.MSG_AUCTION_HELLO, HandleAuctionHello);
            handlers.Add(OpCode.SMSG_AUCTION_LIST_RESULT, HandleAuctionSearchResults);
            handlers.Add(OpCode.SMSG_AUCTION_OWNER_LIST_RESULT, HandleAuctionSearchResults);

            // handlers.Add(OpCode.SMSG_MAIL_LIST_RESULT, Handle_MailList);

            handlers.Add(OpCode.SMSG_LIST_INVENTORY, Handle_VendorInventoryList);
            handlers.Add(OpCode.SMSG_LEVELUP_INFO, Handle_LevelUp);
            handlers.Add(OpCode.SMSG_LOG_XPGAIN, Handle_XpGain);
            handlers.Add(OpCode.SMSG_CAST_FAILED, Handle_SpellFailed);
            handlers.Add(OpCode.SMSG_SPELL_START, Handle_SpellStart);
            handlers.Add(OpCode.SMSG_SPELL_GO, Handle_SpellGo);
            handlers.Add(OpCode.SMSG_ADDON_INFO, (wr) =>
                                                     {
                                                         var ww = new WoWWriter(OpCode.SMSG_ADDON_INFO);
                                                         Send(ww);
                                                     });
            handlers.Add(OpCode.SMSG_LOOT_RESPONSE, Handle_LootResponse);
            //handlers.Add(OpCode.SMSG_LOOT_REMOVED, Handle_LootRemoved);
            handlers.Add(OpCode.SMSG_HEALTH_UPDATE, Handle_HealthUpdate);
            handlers.Add(OpCode.SMSG_MONSTER_MOVE, MonsterMovementHandler);
            handlers.Add(OpCode.MSG_MOVE_TELEPORT_ACK, TeleportHandler);
            handlers.Add(OpCode.SMSG_NEW_WORLD, Handle_NewWorld);
            handlers.Add(OpCode.SMSG_DESTROY_OBJECT, Handle_ObjDestroy);
            handlers.Add(OpCode.SMSG_MESSAGECHAT, Handle_MessageChat);

            /*AddMulti(new List<OpCode>
            {
                    OpCode.MSG_MOVE_HEARTBEAT
                    ,OpCode.MSG_MOVE_START_TURN_RIGHT
                    ,OpCode.MSG_MOVE_STOP
                    ,OpCode.MSG_MOVE_START_TURN_LEFT
                    ,OpCode.MSG_MOVE_START_FORWARD
                    ,OpCode.MSG_MOVE_START_BACKWARD
                    ,OpCode.MSG_MOVE_STOP_TURN
                    ,OpCode.MSG_MOVE_START_STRAFE_LEFT
                    ,OpCode.MSG_MOVE_START_STRAFE_RIGHT
                    ,OpCode.MSG_MOVE_STOP_STRAFE
                    ,OpCode.MSG_MOVE_FALL_LAND
                    ,OpCode.MSG_MOVE_JUMP
                    ,OpCode.MSG_MOVE_SET_FACING
            }, MovementHandler);*/

            handlers.Add(OpCode.SMSG_GAMEOBJECT_CUSTOM_ANIM, Handle_ObjectAnim);

            handlers.Add(OpCode.SMSG_TUTORIAL_FLAGS, (wr) =>
                                                         {
                                                             WoWWriter ww;
                                                             Log(LogType.System, 0, "WS: Requesting Character List...");
                                                             ww = new WoWWriter(OpCode.CMSG_CHAR_ENUM);
                                                             Send(ww);

                                                             ww = new WoWWriter(OpCode.CMSG_REALM_SPLIT);
                                                             ww.Write(4294967295);
                                                             Send(ww);
                                                         });
            handlers.Add(OpCode.SMSG_CHAR_ENUM, Handle_CharEnum);

#if WARDEN
            handlers.Add(OpCode.SMSG_WARDEN_DATA, (wr) =>
                                                      {
                                                          Log(LogType.System, 5, "Got warden packet of size: {0}",
                                                              wr.Remaining);
                                                          var WardenData = new WoWWriter();
                                                          WardenData.Write((byte) 02);
                                                          WardenData.Write((UInt16) wr.Remaining);
                                                          WardenData.Write(wr.ReadRemaining());

                                                          SendWarden(WardenData.ToArray());
                                                          WaitForWarden = false;
                                                      });
#else
            handlers.Add(OpCode.SMSG_WARDEN_DATA, (wr) =>
                                                      {
                                                          /*if (!firstWarden)
                                                          {
                                                              LoginChar(LoggedInCharacter);
                                                              firstWarden = true;
                                                              SendZone();
                                                          }*/
                                                      });
#endif

            /*handlers.Add(OpCode.SMSG_UPDATE_ACCOUNT_DATA, (wr) =>
                {

                });*/

            handlers.Add(OpCode.SMSG_TIME_SYNC_REQ, (wr) =>
                                                        {
                                                            UInt32 timeSequence = wr.ReadUInt();
                                                            Log(LogType.System, 5, "[TimeSync] Req #{0}", timeSequence);

                                                            var ww2 = new WoWWriter(OpCode.CMSG_TIME_SYNC_RESP);
                                                            ww2.Write(timeSequence);
                                                            ww2.Write(Environment.TickCount);
                                                            Send(ww2);
                                                            if (timeSequence == 0 ||
                                                                (timeSequence != 0 && !EngineInited) /* Relog! */)
                                                                SendMovementInit();
                                                        });
            handlers.Add(OpCode.SMSG_PONG, (wr) =>
                                               {
                                                   UInt32 Server_Seq = wr.ReadUInt();
                                                   if (Server_Seq == Ping_Seq)
                                                   {
                                                       Ping_Res_Time = (uint) Environment.TickCount;
                                                       Latency = Ping_Res_Time - Ping_Req_Time;
                                                       Ping_Seq += 1;
                                                       Log(LogType.NeworkComms, 1,
                                                           "Got pong'd with a latency of: {0} sequence: {1}", Latency,
                                                           Server_Seq);
                                                   }
                                                   else
                                                   {
                                                       Log(LogType.Error, 0,
                                                           "Server pong'd bad sequence! Ours: {0} Theirs: {1}", Ping_Seq,
                                                           Server_Seq);
                                                       //Ping_Seq = Server_Seq + 1;
                                                   }
                                               });


            handlers.Add(OpCode.SMSG_AURA_UPDATE_ALL, (wr) => { Handle_AuraUpdate(wr, true); });

            handlers.Add(OpCode.SMSG_ACTION_BUTTONS, (wr) =>
                                                         {
                                                             var ww = new WoWWriter(OpCode.CMSG_REQUEST_ACCOUNT_DATA);
                                                             ww.Write(0);
                                                             Send(ww);


                                                             ww = new WoWWriter(OpCode.CMSG_REQUEST_ACCOUNT_DATA);
                                                             ww.Write(1);
                                                             Send(ww);


                                                             ww = new WoWWriter(OpCode.CMSG_REQUEST_ACCOUNT_DATA);
                                                             ww.Write(7);
                                                             Send(ww);
                                                         });


            handlers.Add(OpCode.SMSG_UPDATE_OBJECT, (wr) => { Handle_ObjUpdate(wr, false); }
                );

            handlers.Add(OpCode.SMSG_COMPRESSED_UPDATE_OBJECT,
                         (wr) => { Handle_ObjUpdate(wr, true); }
                );

            handlers.Add(OpCode.SMSG_ITEM_QUERY_SINGLE_RESPONSE,
                         (wr) => { Handle_ItemQuery(wr, false); }
                );

            handlers.Add(OpCode.SMSG_MOTD, (wr) =>
                                               {
                                                   Ping(null, null);
                                                   PingTimer.Enabled = true;
                                                   Handle_MOTD(wr);
                                               }
                );


            handlers.Add(OpCode.SMSG_AURA_UPDATE, (wr) => { Handle_AuraUpdate(wr, false); }
                );
        }

        protected void processData(byte[] Data)
        {
            var wr = new WoWReader(Data);
            var Op = (OpCode) wr.ReadUInt16();

            Action<WoWReader> action;
            try
            {
                handlers.TryGetValue(Op, out action);

                if (action != null)
                {
                    action(wr);
                }
            }
            catch (Exception ex)
            {
                Log(LogType.Error, 0, "Caught Exception while processing packet with opcode of {0}:  Exception is: {1}",
                    Op, ex.Message);
                if (ex.StackTrace != null)
                    Log(LogType.Error, 0, "{0}", ex.StackTrace);
            }
        }
    }
}