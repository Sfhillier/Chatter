﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Message
    {
        [Required]
        public int MessageID { get; set; }
        [Required]
        public int MemberID { get; set; }
        [Required]
        [Display(Name ="Message")]
        public string MessageText { get; set; }
        public DateTime DateSent { get; set; }
        public bool HasRead { get; set; }
        public Message ThreadID { get; set; }
    }
}