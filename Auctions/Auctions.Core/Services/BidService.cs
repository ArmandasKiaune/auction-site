using Auctions.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Auctions.Core.Services
{
    public class BidService
    {
        public void PlaceBid(Auction auction, int userId, DateTime now, decimal amount)
        {
            if (auction.IsActive == false)
            {
                throw new InvalidOperationException("Auction is not active");
            }
            if (auction.SellerId == userId)
            {
                throw new InvalidOperationException("Item seller cannot place bids");
            }
            if (auction.CurrentPrice >= amount)
            {
                throw new InvalidOperationException("Bid must exceed current bidding price");
            }
            auction.Bids.Add(new Bid
            {
                AuctionId = auction.Id,
                UserId = userId,
                Amount = amount,
                BidDate = now
            });
            auction.CurrentPrice = amount;
        }
    }
}
