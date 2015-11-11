using System;

namespace Chatter.Models
{
    public class Friend
    {
        public int MemberID { get; set; }
        public virtual Member Member { get; set; }
        public DateTime DateFriended { get; set; }
    }
}