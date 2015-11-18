using System;
using System.ComponentModel.DataAnnotations;

namespace Chatter.Models
{
    public class Friend
    {
        [Required]
        public int FriendID { get; set; }
        [Required]
        public int MemberID { get; set; }
        public DateTime DateFriended { get; set; }
    }
}