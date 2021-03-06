﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
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
        [Required]
        public int ProfileID { get; set; }
        [Required]
        public virtual Profile Profile { get; set; }
        [Required]
        public virtual Friend Friend { get; set; }
        [Required]
        public virtual Message Message { get; set; }

    }

    public class MemberDBContext : DbContext
    {
        public DbSet<Member> MyMember { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Member>()
              .HasOptional<Profile>(m => m.Profile)
              .WithRequired(t => t.Member)
              .Map(p => p.MapKey("MemberID"));
        }

        public System.Data.Entity.DbSet<Chatter.Models.Profile> Profiles { get; set; }
    }
}
