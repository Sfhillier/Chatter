using System;
using System.ComponentModel.DataAnnotations;

namespace Chatter.Models
{
    public class Friend
    {
        [Required]
        public int FriendID { get; set; }
        public int MemberID { get; set; }
        public virtual Member Member { get; set; }
        public DateTime DateFriended { get; set; }
    }
}