using System;
using System.Collections.Generic;
using System.Text;

namespace Auctions.Core.Models
{
    public class User
    {
        public required string Name { get; set; }
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
        public required string Status { get; set; }

    }
}
