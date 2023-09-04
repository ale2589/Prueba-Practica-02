﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Football.Models
{
    public class PlayerInfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int number { get; set; }
        public string position { get; set; }
        public string photo { get; set; }
    }
}