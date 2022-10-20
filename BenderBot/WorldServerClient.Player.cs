using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

using Foole.Crypt;
using Foole.Utils;
using Foole.WoW;
using System.Net;



namespace BenderBot.Common
{
    // MyPlayer Packet Handling
    partial class BenderCore
    {
        //#### Need a new home for this :)
        public byte SpellCounter = 0;


        ///<summary>
        ///  
        ///</summary>
        private void Handle_FriendsList(WoWReader wr)
        {
            byte count = wr.ReadByte();

            FriendsListItem[] friendsList = new FriendsListItem[count];

            for (int i = 0; i < count; i++)
            {
                friendsList[i] = new FriendsListItem();
                friendsList[i].guid = new WoWGuid(wr.ReadUInt64());
                friendsList[i].online = wr.ReadBoolean();
                QueryName(friendsList[i].guid);
            }

            Player.FriendsList=friendsList;
        }

        ///<summary>
        ///  
        ///</summary>
        private void Handle_IgnoreList(WoWReader wr)
        {
            byte count = wr.ReadByte();

            IgnoreListItem[] ignoreList = new IgnoreListItem[count];

            for (int i = 0; i < count; i++)
            {
                ignoreList[i] = new IgnoreListItem();
                ignoreList[i].guid = new WoWGuid(wr.ReadUInt64());
                QueryName(ignoreList[i].guid);
            }

            Player.IgnoreList=ignoreList;
        }

        ///<summary>
        ///  
        ///</summary>
        private void Handle_FriendStatus(WoWReader wr)
        {
            FriendsListItem friendStatus = new FriendsListItem();
            friendStatus.guid = new WoWGuid(wr.ReadUInt64());
            friendStatus.online = wr.ReadBoolean();

           // Player.friendStatusUpdate(friendStatus);
        }

        ///<summary>
        /// SMSG_INITIAL_SPELLS
        ///</summary>
        private void Handle_InitialSpells(WoWReader wr)
        {
           byte unknown = wr.ReadByte();           // Dunno. wowd sends a 0.
            UInt16 count = wr.ReadUInt16();

            SpellItem[] spellList = new SpellItem[count];

            for (int i = 0; i < count; i++)
            {
                var spellId = wr.ReadUInt16();
                spellList[i] = SpellItem.GetSpell(spellId);
                wr.ReadUInt16(); //new unk byte. Dual spec?
            }

            uint CoolDownCount = wr.ReadUInt32();              // Another 0 according to wowd.

            Player.Spells = spellList;
            if (Engine != null)
            {
                Engine.CustomClass.CreateSpells();
                Engine.CustomClass.CreateQueues();
            }
        }

        ///<summary>
        ///  SMSG_INITIALIZE_FACTIONS
        ///</summary>
        private void Handle_InitializeFactions(WoWReader wr)
        {
            UInt32 count = wr.ReadUInt();     // always 64 ? 128?!?!

            ReputationItem[] reputationList = new ReputationItem[count];

            for (int i = 0; i < count; i++)
            {
                reputationList[i] = new ReputationItem();
                reputationList[i].Faction = (FactionRepListId)i;
                reputationList[i].Flag = wr.ReadByte();
                reputationList[i].Standing = wr.ReadUInt();
            }

            Player.Reputations= reputationList;
        }


        ///<summary>
        ///  SMSG_LEARNED_SPELL
        ///</summary>
        private void Handle_LearntSpell(WoWReader packet)
        {
            UInt32 spellID = packet.ReadUInt32();

            // Need some kind of event
            // MyPlayer.Spells.learntSpell()
        }

        ///<summary>
        ///  SMSG_SUPERCEDED_SPELL
        ///</summary>
        private void Handle_SupercededSpell(WoWReader packet)
        {
            UInt32 spellID = packet.ReadUInt32();
            UInt32 newSpellID = packet.ReadUInt32();
            // Need some kind of event
            // MyPlayer.Spells.supercededSpell()
        }

        ///<summary>
        ///  SMSG_LEVELUP_INFO
        ///</summary>
        private void Handle_LevelUp(WoWReader packet)
        {
            int level = packet.ReadInt32();
            int hpGain = packet.ReadInt32();
            int manaGain = packet.ReadInt32();
            int strBonus = packet.ReadInt32();
            int agiBonus = packet.ReadInt32();
            int intBonus = packet.ReadInt32();
            int sprBonus = packet.ReadInt32();

            //MyPlayer.levelUp();
        }

        ///<summary>
        ///  SMSG_LOG_XPGAIN
        ///</summary>
        private void Handle_XpGain(WoWReader wr)
        {
            //MyPlayer.xpGain();
            //AI.xpGain(); ??
        }


        ///<summary>
        ///  
        ///</summary>
        private void Handle_AuraUpdate(WoWReader wr, bool UpdateAll)
        {
            

            WoWGuid guid;
            guid = wr.ReadPackedGuid();
            Unit target = World.GetObject(guid) as Unit;
            if (target == null)
            {
                //Log(LogType.Error, 0, "Got aura update for guid with no object {0}", guid);
                return;
            }


            //If this is an update all packet, there will be up to 256 buffs sent for update, but maybe 0. 
            //So start the loop big, and quit when we are out of data.
            //if its not update all, then its a single packet.

            lock (target)
            {
                while (wr.Remaining > 0)
                {
                    Aura aura = new Aura();

                    byte auraIndex = 0;
                    auraIndex = wr.ReadByte();


                    uint spellId = 0;

                    if (wr.Remaining < 4)
                    {

                        //I'm not sure why this happens. We should always have enough bytes for at least spellid=0, but it seems to send less data in some cases.

                    }
                    else
                        spellId = (uint)wr.ReadInt();

                    if (spellId == 0)
                    {
                        Aura oldAura = target.AurasArray[auraIndex];
                        if (oldAura != null)
                        {
                            Log(LogType.NeworkComms, 1, "Removing aura {0} from {1}", oldAura, target.Name);
                        }
                        target.AurasArray[auraIndex] = null;
                        continue;
                    }
                    aura.Spell = SpellItem.GetSpell(spellId);

                    aura.Flags = (AuraFlags)wr.ReadByte();
                    aura.Level = wr.ReadByte();
                    aura.ChargesLeft = wr.ReadByte();
                    WoWGuid casterGuid;
                    if (!aura.Flags.Has(AuraFlags.TargetIsCaster))
                    {
                        casterGuid = wr.ReadPackedGuid();


                        Unit caster = World.GetObject(casterGuid) as Unit;
                        if (caster != null)
                            aura.Caster = caster;
                    }
                    else
                    {
                        aura.Caster = target;
                    }

                    if (aura.Flags.Has(AuraFlags.HasDuration))
                    {
                        aura.Duration = new TimeSpan(0, 0, 0, 0, Convert.ToInt32((uint)wr.ReadInt()));
                        aura.TimeLeftSource = new TimeSpan(0, 0, 0, 0, Convert.ToInt32((uint)wr.ReadInt()));
                        aura.TimeLeftAsOf = DateTime.Now;

                    }
                    Log(LogType.NeworkComms, 1, "Applying aura {0} to {1}", aura, target);
                    target.AurasArray[auraIndex] = aura;
                }
            }
            

        }

        ///<summary>
        /// Receive Trainer Spell List 
        /// SMSG_TRAINER_LIST
        ///</summary
        private void Handle_TrainerList(WoWReader packet)
        {
            WoWGuid trainerGuid = new WoWGuid(packet.ReadUInt64());
            uint trainerSubtype = packet.ReadUInt32();
            int spellCount = packet.ReadInt32();
            List<SpellItem.SpellEntry> spellList = new List<SpellItem.SpellEntry>();
            for (int i = 0; i < spellCount; i++)
            {
                spellList.Add(packet.ReadStruct<SpellItem.SpellEntry>());
            }
            string message = packet.ReadString();
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// Receive Trainer Buy Failed Error
        /// SMSG_TRAINER_BUY_FAILED
        ///</summary>
        private void Handle_TrainerBuyFailed(WoWReader packet)
        {
            WoWGuid trainer_guid = new WoWGuid(packet.ReadUInt64());
            uint serviceType = packet.ReadUInt32();
            uint error = packet.ReadUInt32();
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// Receive Trainer Buy Succeeded
        /// SMSG_TRAINER_BUY_SUCCEEDED
        ///</summary>
        private void Handle_TrainerBuySucceeded(WoWReader packet)
        {
            WoWGuid trainerGuid = new WoWGuid(packet.ReadUInt64());
            uint spell = packet.ReadUInt32();
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// MSG_AUCTION_HELLO
        /// there is not a C or S message, MSG is used for both
        ///</summary>
        private  void Handle_AuctionHello(WoWReader packet)
        {
            WoWGuid auctioneerGuid = new WoWGuid(packet.ReadUInt64());
            uint houseFaction = packet.ReadUInt32();
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_AUCTION_LIST_RESULT
        ///</summary>
        /*private  void Handle_AuctionListResult(WoWReader packet)
        {
            int auctionCount = packet.ReadInt32();
            List<Auction.auction> auction = new List<Auction.auction>();
            for (int i = 0; i < auctionCount; i++)
            {
                auction.Add(packet.ReadStruct<Auction.auction>());
            }
            int length = packet.ReadInt32();
            // #### Can I ignore the rest of the packet> 
            // the server sends 300 more bytes, but we dont need it

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_AUCTION_OWNER_LIST_RESULT
        ///</summary>
        private  void Handle_AuctionOwnerListResult(WoWReader packet)
        {
            int auctionCount = packet.ReadInt32();
            List<Auction.auction> auction = new List<Auction.auction>();
            for (int i = 0; i < auctionCount; i++)
            {
                auction.Add(packet.ReadStruct<Auction.auction>());
            }
            int length = packet.ReadInt32();
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_AUCTION_BIDDER_LIST_RESULT
        ///</summary>
        private  void Handle_AuctionBidderListResult(WoWReader packet)
        {
            int auctionCount = packet.ReadInt32();
            List<Auction.auction> auction = new List<Auction.auction>();
            for (int i = 0; i < auctionCount; i++)
            {
                auction.Add(packet.ReadStruct<Auction.auction>());
            }
            int length = packet.ReadInt32();
            // #### Need to Raise an event of some kind
        }


        ///<summary>
        /// SMSG_AUCTION_COMMAND_RESULT
        ///</summary>
        private  void Handle_AuctionCommandResult(WoWReader packet)
        {
            uint itemLowId = packet.ReadUInt32();
            uint action = packet.ReadUInt32();
            uint error = packet.ReadUInt32();
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_AUCTION_BIDDER_NOTIFICATION
        ///</summary>
        private  void Handle_AuctionBidderNotification(WoWReader packet)
        {
            uint houseFaction = packet.ReadUInt32();
            uint itemLowId = packet.ReadUInt32();
            uint bidderLowId = packet.ReadUInt32();
            uint newBid = packet.ReadUInt32();
            uint minBidInc = packet.ReadUInt32();
            uint itemTemplateId = packet.ReadUInt32();
            uint eod = packet.ReadUInt32();
            // #### Need to Raise an event of some kind
        }*/

        ///<summary>
        /// SMSG_SEND_MAIL_RESULT
        ///</summary>
        private  void Handle_SendMailResult(WoWReader packet)
        {
            uint mailId = packet.ReadUInt32();
            uint result = packet.ReadUInt32();
            uint error = packet.ReadUInt32();
            botEventManager.Raise(BotEventType.MailboxResult, mailId);
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_MAIL_LIST_RESULT
        ///</summary>
        private  void Handle_MailListResult(WoWReader packet)
        {
            packet.ReadUInt();
            int letter_count = packet.ReadByte();
            List<Mail.Letters> letters = new List<Mail.Letters>();
            for (int i = 0; i < letter_count; i++)
            {
                Mail.Letters letter = new Mail.Letters();
                letter.NotSure = packet.ReadInt16();
                letter.LetterGUID = packet.ReadUInt32();
                letter.MessageTypeByte = packet.ReadByte();
                letter.SenderEntityId = packet.ReadUInt32();
                letter.CashOnDelivery = packet.ReadUInt32();
                letter.ItemTextId = packet.ReadUInt32();
                letter.Unknown1 = packet.ReadUInt32();
                letter.MessageStationary = packet.ReadUInt32();
                letter.IncludedMoney = packet.ReadUInt32();
                letter.MailType = packet.ReadUInt32();
                letter.ExpireTime = packet.ReadFloat();
                letter.Unknown2  = packet.ReadUInt32();
                letter.Subject = packet.ReadString();
                letter.ItemCount = packet.ReadByte();
                letter.Items = new List<Mail.LetterItems>();
                Mail.LetterItems li = new Mail.LetterItems();
                for (int ii = 0; ii < letter.ItemCount; ii++)
                {
                    li = new Mail.LetterItems();
                    li.Index = packet.ReadByte();
                    li.EntityLowId = packet.ReadUInt();
                    li.EntryId = packet.ReadUInt();
                    packet.ReadBytes(109);
                    letter.Items.Add(li);
                    //letter.Items.Add(packet.ReadStruct<Mail.LetterItems>());
                }
                letters.Add(letter);
            }
            botEventManager.Raise(BotEventType.MailboxList, letters);
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTGIVER_STATUS
        ///</summary>
        private  void Handle_QuestGiverStatus(WoWReader packet)
        {
            WoWGuid questGiver_guid = new WoWGuid(packet.ReadUInt64());
            Byte highestQuestGiverStatus = packet.ReadByte();
            int count = packet.ReadInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTGIVER_QUEST_LIST
        ///</summary>
        private  void Handle_QuestGiverQuestList(WoWReader packet)
        {
            WoWGuid questholder_guid = new WoWGuid(packet.ReadUInt64());
            string text = packet.ReadString();
            uint playeRemote =  packet.ReadUInt32();
            uint npcEmote = packet.ReadUInt32();
            int listCount = packet.ReadByte();
            List<UInt32> questStatus = new List<UInt32>();
            for (int ii = 0; ii < listCount; ii++)
            {
                questStatus.Add(packet.ReadUInt32());
            }
            uint questLevel = packet.ReadUInt32();
            string questTitle = packet.ReadString();
 
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTGIVER_QUEST_DETAILS
        ///</summary>
        private  void Handle_QuestGiverQuestDetails(WoWReader packet)
        {
            WoWGuid questGiverGuid = new WoWGuid(packet.ReadUInt64());
            UInt32 unknown1 = packet.ReadUInt32();
            UInt32 questTempletId = packet.ReadUInt32();
            String templetTitles = packet.ReadString();
            String templetDetails = packet.ReadString();
            String templetInstructions = packet.ReadString();
            UInt32 acceptable = packet.ReadUInt32(); // 1 for true 0 for false
            UInt32 suggustedPlayers = packet.ReadUInt32();
            UInt32 unknown2 = packet.ReadUInt32();  // probably some pvp flag
            UInt32 unknown3 = packet.ReadUInt32();  // for 3.1



            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTGIVER_REQUEST_ITEMS
        ///</summary>
        private  void Handle_QuestGiverRequestItems(WoWReader packet)
        {
            WoWGuid questGiverGuid = new WoWGuid(packet.ReadUInt64());
            UInt32 questId = packet.ReadUInt32();
            String titleText = packet.ReadString();
            String progressTexts = packet.ReadString();
            UInt32 playerEmoteMaybe = packet.ReadUInt32();
            UInt32 emoteType = packet.ReadUInt32();
            UInt32 closeOnCancel = packet.ReadUInt32();
            UInt32 rewMoney = packet.ReadUInt32();
            UInt32 honorWhatever = packet.ReadUInt32();
            UInt32 amout = packet.ReadUInt32();
            UInt32 templetId = packet.ReadUInt32();
            UInt32 unknown1 = packet.ReadUInt32();
            UInt32 ifCanAdvance = packet.ReadUInt32(); // if can advance: 4
            UInt32 unknown2 = packet.ReadUInt32();       //always eight
            UInt32 unknown3 = packet.ReadUInt32();       // always ten
            Int32 rewardChoiceItemsCount = packet.ReadInt32();
            List<Quest.RewardItems> rewardChoiceItems = new List<Quest.RewardItems>();
            for (int ii = 0; ii < rewardChoiceItemsCount; ii++)
            {
                rewardChoiceItems.Add(packet.ReadStruct<Quest.RewardItems>());
            }
            Int32 rewardItemsCount = packet.ReadInt32();
            List<Quest.RewardItems> rewardItems = new List<Quest.RewardItems>();
            for (int ii = 0; ii < rewardItemsCount; ii++)
            {
                rewardItems.Add(packet.ReadStruct<Quest.RewardItems>());
            }
            Int32 questTempletRewMoney = packet.ReadInt32();
            UInt32 questTempletBonusHonor = packet.ReadUInt32();
            UInt32 questTempletCastSpell = packet.ReadUInt32();
            UInt32 questTempletRewardTitleId = packet.ReadUInt32();
            UInt32 questTempletRewardTalents = packet.ReadUInt32();
            Int32 questDetailedEmotesCount = packet.ReadInt32();
            List<Quest.QuestEmotes> questEmotes = new List<Quest.QuestEmotes>();
            for (int ii = 0; ii < questDetailedEmotesCount; ii++)
            {
                questEmotes.Add(packet.ReadStruct<Quest.QuestEmotes>());
            }

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTGIVER_OFFER_REWARD
        ///</summary>
        private  void Handle_QuestGiverOfferReward(WoWReader packet)
        {
            WoWGuid questGiverGuid = new WoWGuid(packet.ReadUInt64());
            UInt32 questId = packet.ReadUInt32();
            String titleText = packet.ReadString();
            String rewardTexts = packet.ReadString();
            UInt32 followUpQuestId = packet.ReadUInt32();
            UInt32 suggestedPlayers = packet.ReadUInt32();
            Int32 rewardChoiceItemsCount = packet.ReadInt32();
            List<Quest.RewardItems> rewardChoiceItems = new List<Quest.RewardItems>();
            for (int ii = 0; ii < rewardChoiceItemsCount; ii++)
            {
                rewardChoiceItems.Add(packet.ReadStruct<Quest.RewardItems>());
            }
            Int32 rewardItemsCount = packet.ReadInt32();
            List<Quest.RewardItems> rewardItems = new List<Quest.RewardItems>();
            for (int ii = 0; ii < rewardItemsCount; ii++)
            {
                rewardItems.Add(packet.ReadStruct<Quest.RewardItems>());
            }
            UInt32 unused = packet.ReadUInt32();
            UInt32 rewSpell = packet.ReadUInt32();
            UInt32 castSpell = packet.ReadUInt32();
            UInt32 rewardTitleId = packet.ReadUInt32();
            UInt32 rewardTalents = packet.ReadUInt32();
            
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTGIVER_QUEST_INVALID
        ///</summary>
        private  void Handle_QuestgGiverQuestInvalid(WoWReader packet)
        {
            Int32 reason = packet.ReadInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTGIVER_QUEST_COMPLETE
        ///</summary>
        private  void Handle_QuestGiverQuestComplete(WoWReader packet)
        {
            UInt32 questId = packet.ReadUInt32();
            Int32  rewardXp = packet.ReadInt32();
            Int32  money = packet.ReadInt32();
            UInt32 bonusHoner = packet.ReadUInt32();
            UInt32 rewardTalents = packet.ReadUInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTGIVER_QUEST_FAILED
        ///</summary>
        private void Handle_QuestGiverQuestFailed(WoWReader packet)
        {

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTLOG_FULL
        ///</summary>
        private  void Handle_QuestLogFull(WoWReader packet)
        {

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTUPDATE_FAILED
        ///</summary>
        private  void Handle_QuestUpdateFailed(WoWReader packet)
        {
            UInt32 questId = packet.ReadUInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTUPDATE_FAILEDTIMER
        ///</summary>
        private  void Handle_QuestUpdateFailedTimer(WoWReader packet)
        {
            UInt32 questId = packet.ReadUInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTUPDATE_COMPLETE
        ///</summary>
        private  void Handle_QuestUpdateComplete(WoWReader packet)
        {
            UInt32 questId = packet.ReadUInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTUPDATE_ADD_KILL
        ///</summary>
        private  void Handle_QuestUpdateAddKill(WoWReader packet)
        {
            UInt32 templateId = packet.ReadUInt32();
            UInt32 interactionRawId = packet.ReadUInt32();
            UInt32 currentCount = packet.ReadUInt32();
            Int32  interactionAmount = packet.ReadInt32();
            UInt64 objectGuid = packet.ReadUInt64();
    
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUESTUPDATE_ADD_ITEM
        ///</summary>
        private  void Handle_QuestUpdateAddItem(WoWReader packet)
        {
            UInt32 item = packet.ReadUInt32();
            Int32  diff = packet.ReadInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUEST_CONFIRM_ACCEPT
        ///</summary>
        private  void Handle_QuestConfirmAccept(WoWReader packet)
        {
            int reply = packet.ReadInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_DEATH_RELEASE_LOC
        ///</summary>
        private  void Handle_DeathReleaseLocation(WoWReader packet)
        {
            uint     healerRegionId = packet.ReadUInt32();
            Location healerPosition = packet.ReadLocation(false);

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_RESURRECT_FAILED
        ///</summary>
        private  void Handle_ResurrectFailed(WoWReader packet)
        {
            int error = packet.ReadInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_CORPSE_RECLAIM_DELAY
        ///</summary>
        private  void Handle_ReClaimDelay(WoWReader packet)
        {
            uint millis = packet.ReadUInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// MSG_CORPSE_QUERY
        ///</summary>
        private  void Handle_CorpseQuery(WoWReader packet)
        {
            Byte NotSure      = packet.ReadByte();
            uint objRegionId1 = packet.ReadUInt32();
            Location Position = packet.ReadLocation();
            uint objRegionId2 = packet.ReadUInt32();

            // #### Need to Raise an event of some kind

            CorpseLocation = Position;
            CorpseMapId = objRegionId1;
            Log(LogType.Combat, 0, "Got corpse Location: {0} Map: {1}", Position, objRegionId1);
        }

        ///<summary>
        /// SMSG_BUY_FAILED
        ///</summary>
        private  void Handle_BuyFailed(WoWReader packet)
        {
            UInt64 vendorId = packet.ReadUInt64();
            UInt32 itemEntryId = packet.ReadUInt32();
            Byte Error = packet.ReadByte();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_BUY_ITEM
        ///</summary>
        private  void Handle_BuyItem(WoWReader packet)
        {
            UInt64 vendorId = packet.ReadUInt64();
            UInt32 itemEntryId = packet.ReadUInt32();
            UInt32 numItemsPurchased = packet.ReadUInt32();
            UInt32 remainingAmount = packet.ReadUInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_PET_NAME_QUERY_RESPONSE
        ///</summary>
        private  void Handle_PetNameQueryResponse(WoWReader packet)
        {
            UInt32 petID = packet.ReadUInt32();
            string Name = packet.ReadString();
            UInt32 timeStamp = packet.ReadUInt32();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_QUEST_QUERY_RESPONSE
        ///</summary>
        private  void Handle_QuestQueryResponse(WoWReader packet)
        {
            int i; // temp working var
            int REWARDITEMS = 4;
            int REWARDCHOICEITEMS = 6;
            int REQUIREDMOBS = 4;
            int REQUIREDITEMS = 4;
            int OBJECTIVETEXT = 4;

            UInt32 questID = packet.ReadUInt32();
            UInt32 isActive = packet.ReadUInt32();
            UInt32 Level = packet.ReadUInt32();
            Int32  Category = packet.ReadInt32();
            UInt32 type = packet.ReadUInt32();
            UInt32 suggestedPlayers = packet.ReadUInt32();
            UInt32 minReqReputation = packet.ReadUInt32();
            Int32  minReqReputationValue = packet.ReadInt32();
            UInt32 maxReqReputation = packet.ReadUInt32();
            Int32  maxReqReputationValue = packet.ReadInt32();
            UInt32 followupQuestId = packet.ReadUInt32();
            Int32  rewMoney = packet.ReadInt32();
            UInt32 moneyAtMaxLevel = packet.ReadUInt32();
            UInt32 castSpell = packet.ReadUInt32();
            UInt32 rewSpell = packet.ReadUInt32();
            UInt32 bonusHonor = packet.ReadUInt32();
            UInt32 srcItemId = packet.ReadUInt32();
            UInt32 flags = packet.ReadUInt32();
            UInt32 rewardTitleId = packet.ReadUInt32();
            Int32  playerKillCount = packet.ReadInt32();
            UInt32 rewardTalents = packet.ReadUInt32();
 
            List<Quest.QuestQueryResponseItems> rewardItems = new List<Quest.QuestQueryResponseItems>();
            for (i = 0; i < REWARDITEMS; i++)
            {
                rewardItems.Add(packet.ReadStruct<Quest.QuestQueryResponseItems>());
            }

            List<Quest.QuestQueryResponseItems> rewardChoiceitem = new List<Quest.QuestQueryResponseItems>();
            for (i = 0; i < REWARDCHOICEITEMS; i++)
            {
                rewardChoiceitem.Add(packet.ReadStruct<Quest.QuestQueryResponseItems>());
            }

            UInt32 mapID = packet.ReadUInt32();
            float pointX = packet.ReadFloat();
            float pointY = packet.ReadFloat();
            float pointOpt = packet.ReadFloat();

            string titles = packet.ReadString();
            string instructions = packet.ReadString();
            string details = packet.ReadString();
            string endTexts = packet.ReadString();

            List<Quest.QuestQueryResponseItems> requiredMob = new List<Quest.QuestQueryResponseItems>();
            for (i = 0; i < REQUIREDMOBS; i++)
            {
                requiredMob.Add(packet.ReadStruct<Quest.QuestQueryResponseItems>());
            }

            List<Quest.QuestQueryResponseItems> requiredItems = new List<Quest.QuestQueryResponseItems>();
            for (i = 0; i < REQUIREDITEMS; i++)
            {
                requiredItems.Add(packet.ReadStruct<Quest.QuestQueryResponseItems>());
            }

            string[] objectiveText = new string[OBJECTIVETEXT];
            for (i = 0; i < objectiveText.Length; i++)
            {
                objectiveText[i] = packet.ReadString();    // 
            }

        
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_GROUP_INVITE
        ///</summary>
        private  void Handle_GroupInvite(WoWReader packet)
        {
            Byte   unknown  = packet.ReadByte();
            string inviter  = packet.ReadString();

            Query_GroupAccept(); // just for now :P
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_GROUP_DECLINE
        ///</summary>
        private  void Handle_GroupDecline(WoWReader packet)
        {
            string decliner = packet.ReadString();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_GROUP_UNINVITE
        ///</summary>
        private  void Handle_GroupUnInvite(WoWReader packet)
        {
 
            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_GROUP_SET_LEADER
        ///</summary>
        private  void Handle_GroupSetLeader(WoWReader packet)
        {
            string leader = packet.ReadString();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_GROUP_DESTROYED
        ///</summary>
        private  void Handle_GroupDestroyed(WoWReader packet)
        {

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_GROUP_LIST
        ///</summary>
        private  void Handle_GroupList(WoWReader packet)
        {
            Byte groupType = packet.ReadByte();
            Boolean IsBattleGroup = packet.ReadBoolean();
            Byte groupUnitId = packet.ReadByte();
            Byte memberFlags = packet.ReadByte();
            UInt64 nfc = packet.ReadUInt64();  // Hardcoded 0x50000000FFFFFFFEul
            Int32 memberCount = packet.ReadInt32();

            Player.Group = new List<Groups.GroupMember>();
            Groups.GroupMember gmb = null;

            for (int ii = 0; ii < memberCount; ii++)
            {
                // Changed by Lecht -- Below line kept crashing bot.
                // Group.Add(packet.ReadStruct<Groups.GroupMembers>());
                gmb = new Groups.GroupMember(
                    packet.ReadString(),
                    packet.ReadUInt64(),
                    packet.ReadByte(),
                    packet.ReadByte(),
                    packet.ReadByte());
                for (int i = 0; i < World.Players.Count;i++ )
                {
                    if (World.Players[i].GUID.GetOldGuid() == gmb.PlayerID)
                    {
                        gmb.HealthPoints = World.Players[i].HealthPoints;
                        gmb.PowerPoints = World.Players[i].ManaPoints;
                        gmb.MaxHealthPoints = World.Players[i].MaxHealth;
                        gmb.MaxPowerPoints = World.Players[i].MaxMana;
                        World.Players[i].Name = gmb.Name;
                    }
                }
                    Player.Group.Add(gmb);
            }

            UInt64 leaderId      = packet.ReadUInt64();
            Byte   lootMethod    = packet.ReadByte();
            UInt64 lootMasterId  = packet.ReadUInt64();
            Byte   lootThreshold = packet.ReadByte();
            Byte   dungeonMode   = packet.ReadByte();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_GUILD_INVITE
        ///</summary>
        private  void Handle_GuildInvite(WoWReader packet)
        {
            string inviterName = packet.ReadString();
            string guildName = packet.ReadString();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_GUILD_DECLINE
        ///</summary>
        private  void Handle_GuildDecline(WoWReader packet)
        {
            string decliner = packet.ReadString();

            // #### Need to Raise an event of some kind
        }

        ///<summary>
        /// SMSG_ITEM_COOLDOWN
        ///</summary>
        private  void Handle_ItemCoolDown(WoWReader packet)
        {
            UInt64 petID = packet.ReadUInt64();
            UInt32 spellId = packet.ReadUInt32();
 
            // #### Need to Raise an event of some kind
        }




        // The Great Devide .........................................................



        ///<summary>
        ///  CMSG_GROUP_INVITE
        ///</summary>
        public void Query_GroupInvite(String InviteeName)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GROUP_INVITE);
            wr.Write(InviteeName);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_GROUP_ACCEPT
        ///</summary>
        public void Query_GroupAccept()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GROUP_ACCEPT);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_GROUP_DECLINE
        ///</summary>
        public void Query_GroupDecline()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GROUP_DECLINE);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_GROUP_UNINVITE
        ///</summary>
        public void Query_GrouUnInvite(String UnInviteName)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GROUP_UNINVITE);
            wr.Write(UnInviteName);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_GROUP_UNINVITE_GUID
        ///</summary>
        public void Query_GrouUnInviteGUID(UInt64 UnInviteGUID)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GROUP_UNINVITE_GUID);
            wr.Write(UnInviteGUID);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_GROUP_SET_LEADER
        ///</summary>
        public void Query_GroupSetLeader(UInt64 LeaderGUID)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GROUP_SET_LEADER);
            wr.Write(LeaderGUID);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_LOOT_METHOD
        ///</summary>
        public void Query_GroupLootMethod(LootMethod Method, UInt64 LooterGUID, LootItemQuality Item)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_LOOT_METHOD);
            wr.Write((int)Method);
            wr.Write(LooterGUID);
            wr.Write((int)Item);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_GROUP_DISBAND
        ///</summary>
        public void Query_GroupDisband()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GROUP_DISBAND);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_GUILD_INVITE
        ///</summary>
        public void Query_GuildInvite(String InviteeName)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GUILD_INVITE);
            wr.Write(InviteeName);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_GUILD_ACCEPT
        ///</summary>
        public void Query_GuideAccept()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GUILD_ACCEPT);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_GUILD_DECLINE
        ///</summary>
        public void Query_GuideDecline()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GUILD_DECLINE);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_OPEN_ITEM
        ///</summary>
        public void Query_OpenItem(Byte BagSlot, Byte ItemSlot)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_OPEN_ITEM);
            wr.Write(BagSlot);
            wr.Write(ItemSlot);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_IGNORE_TRADE
        ///</summary>
        public void Query_IgnoreTrade()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_IGNORE_TRADE);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_ACCEPT_TRADE
        ///</summary>
        public void Query_AcceptTrade()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_ACCEPT_TRADE);
            Send(wr);
        }
          
        ///<summary>
        ///  CMSG_ADD_IGNORE
        ///</summary>
        public void Query_QuestQuery(string CharacterName)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_ADD_IGNORE);
            wr.Write(CharacterName);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_DEL_IGNORE
        ///</summary>
        public void Query_QuestQuery(UInt64 CharacterID)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_DEL_IGNORE);
            wr.Write(CharacterID);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_QUEST_QUERY
        ///</summary>
        public void Query_QuestQuery(UInt32 QuestID)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUEST_QUERY);
            wr.Write(QuestID);
            Send(wr);
        }  

        ///<summary>
        ///  CMSG_PET_NAME_QUERY
        ///</summary>
        public void Query_LearnTalent(UInt32 PetNumber, UInt64 PetEntityId)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_LEARN_TALENT);
            wr.Write(PetNumber);
            wr.Write(PetEntityId);
            Send(wr);
        }       
        
        ///<summary>
        ///  CMSG_LEARN_TALENT
        ///</summary>
        public void Query_LearnTalent(UInt32 TalentId, UInt32 Rank)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_LEARN_TALENT);
            wr.Write(TalentId);
            wr.Write(Rank);
             Send(wr);
        }
 
        ///<summary>
        ///  CMSG_BUY_ITEM
        ///</summary>
        public void Query_BuyItem(UInt64 Vendor, UInt64 ItemID, UInt32 Count)
        {
            float unknownfloat = 0;
            WoWWriter wr = new WoWWriter(OpCode.CMSG_BUY_ITEM);
            wr.Write(Vendor);
            wr.Write(ItemID);
            wr.Write(unknownfloat);
            wr.Write(Count);
            Send(wr);
        }
            
        ///<summary>
        ///  CMSG_BUY_ITEM_IN_SLOT
        ///</summary>
        public void Query_BuyItemInSlot(BuyItems Items)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_BUY_ITEM_IN_SLOT);
            wr.Write(Items.Vendor);
            wr.Write(Items.ItemID);
            wr.Write(Items.Slot);
            wr.Write(Items.BagID);
            wr.Write(Items.BagSlot);
            wr.Write(Items.Amount);
            Send(wr);
        }
        
        ///<summary>
        ///  CMSG_IGNORE_TRADE
        ///</summary>
        public void Query_IgnoreTrade(Int64 SpiritHealer)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_IGNORE_TRADE);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_ACCEPT_TRADE
        ///</summary>
        public void Query_AcceptTrade(Int64 SpiritHealer)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_ACCEPT_TRADE);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_CANCEL_TRADE
        ///</summary>
        public void Query_CancelTrade(Int64 SpiritHealer)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_CANCEL_TRADE);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_SPIRIT_HEALER_ACTIVATE
        ///</summary>
        public void Query_SpiritHealerActivate(Int64 SpiritHealer)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_SPIRIT_HEALER_ACTIVATE);
            wr.Write(SpiritHealer);
            Send(wr);
        }

        ///<summary>
        ///  MSG_CORPSE_QUERY
        ///</summary>
        public void CorpseQuery()
        {
            WoWWriter wr = new WoWWriter(OpCode.MSG_CORPSE_QUERY);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_REPOP_REQUEST
        ///  Used to release your corpse after death
        ///</summary>
        public void Repop()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_REPOP_REQUEST);
            wr.Write((byte)0);
            Send(wr);
        }


        ///<summary>
        ///  CMSG_RECLAIM_CORPSE
        ///</summary>
        public void Revive()
        {
            WowObject corpse = (from u in World.Objects
                                   where MyCorpse(u)
                                   select u).FirstOrDefault();

            if (corpse != null)
            {
                WoWWriter wr = new WoWWriter(OpCode.CMSG_RECLAIM_CORPSE);
                wr.Write(corpse.GUID.GetOldGuid());
                Send(wr);
            }
        }

        private bool MyCorpse(WowObject obj)
        {
            if (obj.Type != ObjectTypeId.Corpse)
                return false;

            uint guid_hi = obj.GetField((int)UpdateFields.CORPSE_FIELD_OWNER);
            uint guid_lo = obj.GetField((int)UpdateFields.CORPSE_FIELD_OWNER_01);

            ulong guid = ((ulong)guid_hi << 32) | guid_lo;

            if (guid == Player.GUID.GetOldGuid())
                return true;

            return false;
        }

        ///<summary>
        ///  CMSG_LIST_INVENTORY
        ///</summary>
        public void Query_ListInventory(UInt64 VendorID)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_LIST_INVENTORY);
            wr.Write(VendorID);
            Send(wr);
        }
        
        ///<summary>
        ///  CMSG_QUESTLOG_REMOVE_QUEST
        ///</summary>
        public void Query_QuestLogRemoveQuest(Byte Slot)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUESTLOG_REMOVE_QUEST);
            wr.Write(Slot);
            Send(wr);
        }
        
        ///<summary>
        ///  CMSG_QUEST_CONFIRM_ACCEPT
        ///</summary>
        public void Query_QuestConfirmAccept()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUEST_CONFIRM_ACCEPT);
            Send(wr);
        }
        
        ///<summary>
        ///  CMSG_QUESTLOG_SWAP_QUEST
        ///</summary>
        public void Query_QuestLogSwapQuest()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUESTLOG_SWAP_QUEST);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_QUESTGIVER_CANCEL
        ///</summary>
        public void Query_QuestGiverCancel()
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUESTGIVER_CANCEL);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_QUESTGIVER_CHOOSE_REWARD
        ///</summary>
        public void Query_QuestGiverChooseReward(UInt64 QuestGiver, UInt32 QuestID, UInt32 RewardSlot)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUESTGIVER_CHOOSE_REWARD);
            wr.Write(QuestGiver);
            wr.Write(QuestID);
            wr.Write(RewardSlot);
            Send(wr);
        }


        ///<summary>
        ///  CMSG_QUESTGIVER_REQUEST_REWARD
        ///</summary>
        public void Query_QuestGiverRequestReward(UInt64 QuestGiver, UInt32 QuestID)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUESTGIVER_REQUEST_REWARD);
            wr.Write(QuestGiver);
            wr.Write(QuestID);
            Send(wr);
        }
                
        ///<summary>
        ///  CMSG_QUESTGIVER_COMPLETE_QUEST
        ///</summary>
        public void Query_QuestGiverComplete(UInt64 QuestGiver, UInt32 QuestID)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUESTGIVER_COMPLETE_QUEST);
            wr.Write(QuestGiver);
            wr.Write(QuestID);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_QUESTGIVER_ACCEPT_QUEST
        ///</summary>
        public void Query_QuestGiverAccept(UInt64 QuestGiver, UInt32 QuestID)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUESTGIVER_ACCEPT_QUEST);
            wr.Write(QuestGiver);
            wr.Write(QuestID);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_QUESTGIVER_QUERY_QUEST
        ///</summary>
        public void Query_QuestGiverQuery(UInt64 QuestGiver, UInt32 QuestID)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUESTGIVER_QUERY_QUEST);
            wr.Write(QuestGiver);
            wr.Write(QuestID);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_QUESTGIVER_STATUS_QUERY
        ///</summary>
        public void Query_QuestGiverStatus(UInt64 QuestGiver)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUESTGIVER_STATUS_QUERY);
            wr.Write(QuestGiver);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_QUESTGIVER_HELLO
        ///</summary>
        public void Query_QuestGiverHello(UInt64 QuestGiver)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_QUESTGIVER_HELLO);
            wr.Write(QuestGiver);
            Send(wr);
        }

        
        ///<summary>
        ///  CMSG_MAIL_CREATE_TEXT_ITEM
        ///</summary>
        public void Query_MailCreateText(UInt64 MailBoxId, UInt32 MailId)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_MAIL_CREATE_TEXT_ITEM);
            wr.Write(MailBoxId);
            wr.Write(MailId);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_MAIL_DELETE
        ///</summary>
        public void Query_MailDelete(UInt64 MailBoxId, UInt32 MailId)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_MAIL_DELETE);
            wr.Write(MailBoxId);
            wr.Write(MailId);
            wr.Write(3u);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_MAIL_RETURN_TO_SENDER
        ///</summary>
        public void Query_MailReturnToSender(UInt64 MailBoxId, UInt32 MailId)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_MAIL_RETURN_TO_SENDER);
            wr.Write(MailBoxId);
            wr.Write(MailId);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_MAIL_MARK_AS_READ
        ///</summary>
        public void Query_MailMarkAsRead(UInt64 MailBoxId, UInt32 MailId)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_MAIL_MARK_AS_READ);
            wr.Write(MailBoxId);
            wr.Write(MailId);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_MAIL_TAKE_ITEM
        ///</summary>
        public void Query_MailTakeItem(UInt64 MailBoxId, UInt32 MailId, UInt32 ItemId)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_MAIL_TAKE_ITEM);
            wr.Write(MailBoxId);
            wr.Write(MailId);
            wr.Write(ItemId);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_MAIL_TAKE_MONEY
        ///</summary>
        public void Query_MailTakeMoney(UInt64 MailBoxId, UInt32 MailId)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_MAIL_TAKE_MONEY);
            wr.Write(MailBoxId);
            wr.Write(MailId);

            Send(wr);
        }

        ///<summary>
        ///  CMSG_GET_MAIL_LIST
        ///</summary>
        public void Query_GetMailList(UInt64 MailBoxId)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GET_MAIL_LIST);
            wr.Write(MailBoxId);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_SEND_MAIL
        ///</summary>
        public void Query_SendMail(Mail.MailPackage Message)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_SEND_MAIL);
            wr.Write(Message.mailboxId);
            wr.Write(Message.recipientName);
            wr.Write(Message.Subject);
            wr.Write(Message.Msg);
            wr.Write(Message.Stationary);
            wr.Write(Message.Unknown1);
            wr.Write(Message.ItemCount);
            foreach (Mail.MailItems item in Message.Items)
            {
                wr.Write(item.Slot);
                wr.Write(item.ItemID);
            }
            wr.Write(Message.Money);
            wr.Write(Message.COD);
            wr.Write(Message.Unknown2);
            wr.Write(Message.Unknown3);
            Send(wr);
        }


        ///<summary>
        ///  CMSG_AUCTION_LIST_BIDDER_ITEMS
        ///</summary>
        public void Query_AuctionListPendingSales(UInt32 AuctionId)
        {
            // OK, this might be a typeo in Wcell,  but I think it shouw be Auction not Auctioner
            WoWWriter wr = new WoWWriter(OpCode.CMSG_AUCTION_LIST_BIDDER_ITEMS);
            wr.Write(AuctionId);
            Send(wr);
        }
        
        ///<summary>
        ///  CMSG_AUCTION_LIST_PENDING_SALES
        ///</summary>
        public void Query_AuctionListPendingSales(WoWGuid Auctioneer_guid, UInt32 AuctionId)
        {
            // Not Used But Got Carried Away and codded it anyway,  lol
            //WoWWriter wr = new WoWWriter(OpCode.CMSG_AUCTION_LIST_PENDING_SALES);
            //wr.Write(Auctioneer_guid.GetOldGuid());
            //wr.Write(Auction_guid.GetOldGuid());
            //Send(wr);
        }

        ///<summary>
        ///  CMSG_AUCTION_PLACE_BID
        ///</summary>
        public void Query_AuctionPlaceBid(WoWGuid Auctioneer_guid, UInt32 AuctionId, Int32 Bid)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_AUCTION_PLACE_BID);
            wr.Write(Auctioneer_guid.GetOldGuid());
            wr.Write(AuctionId);
            wr.Write(Bid);
            Send(wr);
        }

        ///<summary>
        ///  CMSG_AUCTION_LIST_OWNER_ITEMS
        ///</summary>
        public void Query_AuctionListOwnerItelms(WoWGuid Auctioneer_guid)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_AUCTION_LIST_OWNER_ITEMS);
            wr.Write(Auctioneer_guid.GetOldGuid());
            Send(wr);
        }


        ///<summary>
        ///    CMSG_AUCTION_LIST_ITEMS
        ///</summary>
        /*public void Query_AuctionListItems(WoWGuid Auctioneer_guid, Auction.ListRequest List)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_AUCTION_LIST_ITEMS);
            wr.Write(Auctioneer_guid.GetOldGuid());
            wr.Write(List.StartIndex);
            wr.Write(List.Name);
            wr.Write(List.LevelRange1);
            wr.Write(List.LevelRange2);
            wr.Write(List.InventoryType);
            wr.Write(List.ItemClass);
            wr.Write(List.ItemSubClass);
            wr.Write(List.Quality);
            wr.Write(List.IsUsable);
            Send(wr);
        }*/       
        
        
        ///<summary>
        /// CMSG_AUCTION_REMOVE_ITEM
        ///</summary>
        public void Query_AuctionHello(WoWGuid Auctioneer_guid, UInt32 AuctionId)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_AUCTION_REMOVE_ITEM);
            wr.Write(Auctioneer_guid.GetOldGuid());
            wr.Write(AuctionId);
            Send(wr);
        }


        ///<summary>
        /// CMSG_AUCTION_SELL_ITEM
        ///</summary>
        public void Query_AuctionSellItem(WoWGuid Auctioneer_guid, UInt64 itemId, UInt32 bid, UInt32 buyout, Int32 time)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_AUCTION_SELL_ITEM);
            wr.Write(Auctioneer_guid.GetOldGuid());
            wr.Write((uint)0x01);
            wr.Write(itemId);
            wr.Write((uint)0x00);
            wr.Write(bid);
            wr.Write(buyout);
            wr.Write(time);
            Send(wr);
        }

        ///<summary>
        /// C-MSG_AUCTION_HELLO
        /// there is not a C or S message, MSG is used for both
        ///</summary>
        public void Query_AuctionHello(WoWGuid Auctioneer_guid)
        {
            WoWWriter wr = new WoWWriter(OpCode.MSG_AUCTION_HELLO);
            wr.Write(Auctioneer_guid.GetOldGuid());
            Send(wr);
        }
                
        ///<summary>
        /// Call to send Receive List of Spell from Trainer
        ///</summary>
        public void Query_TrainerList(WoWGuid trainer_guid)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_TRAINER_LIST);
            wr.Write(trainer_guid.GetOldGuid());
            Send(wr);
        }

        ///<summary>
        ///Call to send Buy Spell Request to trainer
        ///</summary>
        public void Query_TrainerBuySpell(WoWGuid trainer_guid, Int32 SpellId)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_TRAINER_BUY_SPELL);
            wr.Write(trainer_guid.GetOldGuid());
            wr.Write(SpellId);
            Send(wr);
        }

        public void Query_GetMailList(WoWGuid mailbox_guid)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_GET_MAIL_LIST);
            wr.Write(mailbox_guid.GetOldGuid());
            Send(wr);
        }
    

        public void Target(Unit target)
        {
            if (target != null && Player.Target != target)
            {
                Log(LogType.NeworkComms, 1, "Sending target command on {0} {1}", target.Name, target.GUID);
                WoWWriter wr;

                wr = new WoWWriter(OpCode.CMSG_SET_SELECTION);
                wr.Write(target.GUID.GetOldGuid());
                Send(wr);
                
                Player.Target = target;
            }

        }

        public event EventHandler<EventArgs<GenericEventArgs>> GenericEvent;


        private void Handle_SellItem(WoWReader packet)
        {

            WoWGuid vendorGuid = packet.ReadUnpackedGuid();

            WoWGuid itemGuid = packet.ReadUnpackedGuid();

            SellItemError result = (SellItemError) packet.ReadByte();

            GenericEvent.Raise(this, new EventArgs<GenericEventArgs>(new GenericEventArgs("ItemSold", result)));

        }
        

        public void SellItem(Unit vendor, Item item, byte count)
        {
            SellItem(vendor.GUID, item.GUID, count);
        }

        public void ListInventory(Unit vendor)
        {
            Query_ListInventory(vendor.GUID.GetOldGuid());
        }

        public void SellItem(WoWGuid VendorGUID, WoWGuid ItemGUID, byte count)
        {
            var wr = new WoWWriter(OpCode.CMSG_SELL_ITEM);
            wr.Write(VendorGUID.GetOldGuid());
            wr.Write(ItemGUID.GetOldGuid());
            wr.Write((uint)count);

            Send(wr);
        }

        public void UseItem(string Name)
        {
            Item tmp = Player.Inventory.FindItem(Name);
            InventorySearchResult isr = Player.Inventory.FindItem(tmp);
            if (isr.InventorySlot == 0)
                return;
            WoWWriter wr = new WoWWriter(OpCode.CMSG_USE_ITEM);
            wr.Write((byte)isr.InventorySlot);
            byte bagSlot = 0x00;
            bagSlot = isr.InventorySlot == 0xFF ? (byte)(0x17 + isr.BagSlot) : (byte)isr.BagSlot;
            wr.Write(bagSlot);
            wr.Write((byte)01);
            wr.Write(tmp.Template.Spells[0].Id);
            wr.Write(tmp.GUID.GetOldGuid());
            wr.Write(0);
            wr.Write(0);
            wr.Write((byte)0);
            Send(wr);
        }


        public bool runSpeedChanged = false;
        private void Handle_ForceRunSpeedChange(WoWReader obj)
        {
            WoWGuid guid = obj.ReadPackedGuid();
            uint count = obj.ReadUInt();
            byte unknown = obj.ReadByte();
            float speed = obj.ReadFloat();
            var wr = new WoWWriter(OpCode.CMSG_FORCE_RUN_SPEED_CHANGE_ACK);
            wr.Write(guid.PackedGuid());
            wr.Write(count);
            wr.Write((uint)0);
            wr.Write((short)0);
            wr.Write(Environment.TickCount);
            wr.Write(RealMover.Position.X);
            wr.Write(RealMover.Position.Y);
            wr.Write(RealMover.Position.Z);
            wr.Write(RealMover.Position.Orientation);
            wr.Write((uint)0xAF);
            wr.Write(speed);
            Send(wr);
            Player.MoveBlock.RunSpeed = speed;
            Engine.SendLog("Changing Run speed to: " + speed);
            runSpeedChanged = true;
        }

        public bool flying = false;
        public bool flightSpeedChanged = false;
        private void Handle_ForceFlightSpeedChange(WoWReader obj)
        {
            WoWGuid guid = obj.ReadPackedGuid();
            uint count = obj.ReadUInt();
            float speed = obj.ReadFloat();
            var wr = new WoWWriter(OpCode.CMSG_FORCE_FLIGHT_SPEED_CHANGE_ACK);
            wr.Write(guid.PackedGuid());
            wr.Write(count);
            wr.Write((uint)0);
            wr.Write((short)0);
            wr.Write(Environment.TickCount);
            wr.Write(RealMover.Position.X);
            wr.Write(RealMover.Position.Y);
            wr.Write(RealMover.Position.Z);
            wr.Write(RealMover.Position.Orientation);
            wr.Write((uint)0x00);
            wr.Write(speed);
            Send(wr);
            Player.MoveBlock.FlySpeed = speed;
            Engine.SendLog("Changing Flight speed to: " + speed);
            flightSpeedChanged = true;
        }

        public bool receivedCanFly = false;
        private void Handle_CanFly(WoWReader obj)
        {
            var wr = new WoWWriter(OpCode.CMSG_MOVE_SET_CAN_FLY_ACK);
            wr.Write(obj.ReadPackedGuid().PackedGuid());
            wr.Write(obj.ReadUInt());
            wr.Write((uint)0x01000000);
            wr.Write((ushort)0);
            wr.Write(Environment.TickCount);
            wr.Write(RealMover.Position.X);
            wr.Write(RealMover.Position.Y);
            wr.Write(RealMover.Position.Z);
            wr.Write(RealMover.Position.Orientation);
            wr.Write((uint)0xAF);
            wr.Write((float)1);
            Send(wr);
            Engine.SendLog("Yay server says we can fly! To infinity and beyond!");
            receivedCanFly = true;
            //flying = true;
        }
        private void Handle_UnsetCanFly(WoWReader obj)
        {
            var wr = new WoWWriter(OpCode.CMSG_MOVE_SET_CAN_FLY_ACK);
            wr.Write(obj.ReadPackedGuid().PackedGuid());
            wr.Write(obj.ReadUInt());
            wr.Write((uint)0);
            wr.Write((ushort)0);
            wr.Write(Environment.TickCount);
            wr.Write(RealMover.Position.X);
            wr.Write(RealMover.Position.Y);
            wr.Write(RealMover.Position.Z);
            wr.Write(RealMover.Position.Orientation);
            wr.Write((uint)0);
            wr.Write((float)0);
            Send(wr);
            flying = false;
            Engine.SendLog("Bringing her in for a landing.");
            receivedCanFly = true;
        }

        private void Handle_ItemPush(WoWReader obj)
        {
            obj.ReadUInt64();
            obj.ReadInt();
            obj.ReadInt();
            obj.ReadInt();
            int slot = (int) obj.ReadByte();
            int contslot = obj.ReadInt();
            uint template = obj.ReadUInt();
            obj.ReadInt();
            obj.ReadInt();
            int amount = obj.ReadInt();
            if (!ItemTemplate.Templates.ContainsKey(template))
            {
                var temp = new ItemTemplate();
                temp.Id = template;
                ItemTemplate.Templates[template] = temp;
                Query_Item_Single(template);
            }
            Log(LogType.System, 0, "Slot: " + slot + " - ContSlot: " + contslot);
        }
    }
}
