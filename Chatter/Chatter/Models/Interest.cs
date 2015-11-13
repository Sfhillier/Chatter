using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Interest
    {
        [Required]
        public int InterestID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}