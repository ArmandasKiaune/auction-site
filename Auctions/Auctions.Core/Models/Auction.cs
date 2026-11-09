using System;
using System.Collections.Generic;
using System.Text;

namespace Auctions.Core.Models;

    public class Auction
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal StartingPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int SellerId { get; set; }
        public int? WinnerId { get; set; }
        public bool IsActive => DateTime.UtcNow >= StartDate && DateTime.UtcNow <= EndDate;
        public required string AuctionStatus { get; set; }
        public List<Bid> Bids { get; set; } = new List<Bid>();
    }