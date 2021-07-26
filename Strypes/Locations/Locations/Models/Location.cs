// <copyright file="Location.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.Models.Enums;

    public class Location
    {
        public Location()
        {
            this.LocationId = Guid.NewGuid().ToString();
        }

        [Key]
        [Required]
        [MaxLength(39)]
        public string LocationId { get; set; }

        [Required]
        [EnumDataType(typeof(LocationType))]
        public LocationType Type { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(45)]
        public string Address { get; set; }

        [Required]
        [MaxLength(45)]
        public string City { get; set; }

        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; }

        [Required]
        [MaxLength(45)]
        public string Country { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; }

        public virtual ICollection<ChargePoint> ChargePoints { get; set; }
    }
}