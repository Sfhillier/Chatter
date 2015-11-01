using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Demographic
    {
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }

    }
}