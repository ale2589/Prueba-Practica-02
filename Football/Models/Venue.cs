using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Football.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Capacity { get; set; }
        public string Surface { get; set; }
        public string Image { get; set; }
    }
}