using Auctions.Core.Models;
using Auctions.Core.Services;

public class BidServiceTests
{
    [Fact]
    public void PlaceBid_LowerThanCurrentPrice_Throws()
    {
        var now = DateTime.UtcNow;
        var auction = new Auction
        {
            Name = "Test",
            Description = "Test",
            StartingPrice = 100,
            CurrentPrice = 100,
            StartDate = now.AddDays(-1),
            EndDate = now.AddDays(1),
            SellerId = 1,
            AuctionStatus = "Active"
            // set status here once it's an enum
        };
        var service = new BidService();

        Assert.Throws<InvalidOperationException>(
            () => service.PlaceBid(auction, /* userId */ 2, now, /* amount */ 50));
    }
}