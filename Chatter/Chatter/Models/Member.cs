using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        [Required]
        [StringLength(maximumLength:20,ErrorMessage ="Please enter a name between 2 and 20 characters.",MinimumLength =2)]
        public string UserName { get; set; }

    }
}