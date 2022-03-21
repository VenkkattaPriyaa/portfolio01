using System;
using System.Collections.Generic;

#nullable disable

namespace PortfolioAPI.Models
{
    public partial class Investors
    {

        public int Id { get; set; }

        public string ProfilePic { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        
        public string Gender { get; set; }
    }
}
