using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Football.Models
{
    public class TeamInfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string logo { get; set; }
        public List<PlayerInfo> players { get; set; }
    }
}