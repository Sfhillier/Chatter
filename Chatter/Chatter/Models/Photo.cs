using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Photo
    {
        public string Path { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool ProfilePicture { get; set; }
    }
}