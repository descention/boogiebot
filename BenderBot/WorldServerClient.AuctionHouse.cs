using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foole.WoW;

namespace BenderBot.Common
{
    partial class BenderCore
    {
        public void AuctionSearch(Unit auctioneer, int startIndex, string Name, byte levelRange1, byte levelRange2, uint inventoryType, uint itemClass, uint itemSubClass, uint rarityCheck, byte useableCheck)
        {
            var wr = new WoWWriter(OpCode.CMSG_AUCTION_LIST_ITEMS);
            wr.Write(auctioneer.GUID.GetOldGuid());
            wr.Write(startIndex);
            wr.Write(Name);
            wr.Write(levelRange1);
            wr.Write(levelRange2);
            wr.Write(inventoryType);
            wr.Write(itemClass);
            wr.Write(itemSubClass);
            wr.Write(rarityCheck);
            wr.Write(useableCheck);
            wr.Write(0x00070100); // Dunno wtf this shit is but it's static
            wr.Write(0x00010500); // Dunno wtf this shit is but it's static
            wr.Write(0x06000901); // Dunno wtf this shit is but it's static
            wr.Write(0x08000300); // Dunno wtf this shit is but it's static
            Send(wr);
        }

        private void Query_Auctioneer(ulong ID)
        {
            var wr = new WoWWriter(OpCode.MSG_AUCTION_HELLO);
            wr.Write(ID);
            Send(wr);
        }

        public void InitAuction(Unit Auctioneer)
        {
            Query_Auctioneer(Auctioneer.GUID.GetOldGuid());
        }

        private void HandleAuctionHello(WoWReader packet)
        {
            ulong auctioneer = packet.ReadUInt64();

            var wr = new WoWWriter(OpCode.CMSG_AUCTION_LIST_BIDDER_ITEMS);
            wr.Write(auctioneer);
            wr.Write((uint)0);
            wr.Write((uint)0);
            Send(wr);

            wr = new WoWWriter(OpCode.CMSG_AUCTION_LIST_OWNER_ITEMS);
            wr.Write(auctioneer);
            wr.Write((uint)0);
            Send(wr);

            wr = new WoWWriter(OpCode.CMSG_AUCTION_LIST_PENDING_SALES);
            wr.Write(auctioneer);
            Send(wr);

            AuctionHandshakeFinished = true;
        }

        public List<AuctionItem> AuctionItems { get; set; }
        public bool AuctionHandshakeFinished { get; set; }
        public bool AuctionSearchFinished { get; set; }
        public int AuctionItemCount;
        private void HandleAuctionSearchResults(WoWReader packet)
        {
            AuctionItemCount = 0;
            AuctionItems = new List<AuctionItem>();
            int numItems = packet.ReadInt();
            uint auctionId = 0;
            uint templateId;
            AuctionItem tmp = null;
            for (int i=0; i<numItems; i++)
            {
                auctionId = packet.ReadUInt();
                templateId = packet.ReadUInt();

                // Enchantment info for item -- unhandled for now
                for (int a=0;a<6;a++)
                {
                    packet.ReadUInt(); // Entry Id
                    packet.ReadUInt(); // Slot
                    packet.ReadUInt(); // Charges
                }

                tmp = new AuctionItem(
                    auctionId,
                    templateId,
                    packet.ReadUInt(),
                    packet.ReadInt()
                    );
                packet.ReadUInt(); // Unknown
                packet.ReadUInt(); // Unknown
                packet.ReadUInt(); // Unknown
                tmp.Amount = packet.ReadUInt();
                packet.ReadUInt(); // Unknown
                packet.ReadUInt(); // Unknown
                tmp.OwnerId = packet.ReadUInt64();
                tmp.StartBid = packet.ReadUInt();
                packet.ReadUInt(); // Unknown -- always 0x32
                tmp.BuyoutPrice = packet.ReadUInt();
                tmp.MillisecondsLeft = packet.ReadInt();
                tmp.BidderId = packet.ReadUInt64();
                tmp.CurrentBid = packet.ReadUInt();
                AuctionItems.Add(tmp);
            }
            AuctionItemCount = packet.ReadInt32();
            AuctionSearchFinished = true;
        }

        public bool receivedCommandResult = false;
        private void Handle_AuctionCommandResult(WoWReader obj)
        {
            receivedCommandResult = true;
        }
    }
}
