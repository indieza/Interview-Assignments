// <copyright file="MyDbContext.cs" company="One To One Relationship With Enumeration">
// Copyright (c) One To One Relationship With Enumeration. All rights reserved.
// </copyright>

namespace OneToOneRelationshipWithEnumeration.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using OneToOneRelationshipWithEnumeration.Models;

    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public DbSet<UserAction> UserActions { get; set; }

        public DbSet<FollowUserAction> FollowUserActions { get; set; }

        public DbSet<UnfollowUserAction> UnfollowUserActions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=True;Server=DESKTOP-OL15CV8;Database=OneToOne");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FollowUserAction>().ToTable("FollowUserActions");
            modelBuilder.Entity<UnfollowUserAction>().ToTable("UnfollowUserActions");

            modelBuilder.Entity<UserAction>()
                .HasOne(x => x.BaseUserAction)
                .WithOne(x => x.UserAction)
                .HasForeignKey<UserAction>(x => x.BaseUserActionId)
                .IsRequired(false);
        }
    }
}