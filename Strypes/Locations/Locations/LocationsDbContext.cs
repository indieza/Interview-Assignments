// <copyright file="LocationsDbContext.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.Models;

    using Microsoft.EntityFrameworkCore;

    public class LocationsDbContext : DbContext
    {
        public LocationsDbContext(DbContextOptions<LocationsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }

        public DbSet<ChargePoint> ChargePoints { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Location>().HasKey(x => x.LocationId);
            builder.Entity<ChargePoint>().HasKey(x => x.ChargePointId);

            builder.Entity<Location>().HasMany(x => x.ChargePoints)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.LocationId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}