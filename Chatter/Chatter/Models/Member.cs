using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Member
    {
        [Required]
        public int MemberID { get; set; }
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "Please enter a name between 2 and 20 characters.", MinimumLength = 2)]
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "Please enter a name between 2 and 20 characters.", MinimumLength = 2)]
        public string DisplayName { get; set; }
        [Required]
        public DateTime DateJoined { get; set; }
        public DateTime LastLogin { get; set; }
        [Key, ForeignKey("ProfileID")]
        [Column(Order =0)]
        [Required]
        public int ProfileID { get; set; }
        [Required]
        public virtual Profile Profile { get; set; }
        [Key, ForeignKey("FriendID")]
        [Column(Order =1)]
        [Required]
        public int FriendID { get; set; }
        [Required]
        public virtual Friend Friend { get; set; }
        [Key, ForeignKey("MessageID")]
        [Column(Order =2)]
        [Required]
        public int MessageID { get; set; }
        [Required]
        public virtual Message Message { get; set; }

    }
}
