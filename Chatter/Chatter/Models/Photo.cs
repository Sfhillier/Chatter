using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Photo
    {
        [Required]
        public int PhotoID { get; set; }
        [Required]
        public string Path { get; set; }
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Please enter a description between 5 and 50 characters.", MinimumLength = 5)]
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        [Required]
        public bool ProfilePicture { get; set; }
    }
}