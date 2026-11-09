using System;
using System.Collections.Generic;
using System.Text;

namespace Auctions.Core.StatusResult
{
    public enum AuctionStatus
    {
        Draft,
        Active,
        Paused,
        Ended,
        NotFound
    }
}
