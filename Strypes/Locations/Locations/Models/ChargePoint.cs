// <copyright file="ChargePoint.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Locations.Models.Enums;

    public class ChargePoint
    {
        public ChargePoint()
        {
            this.ChargePointId = Guid.NewGuid().ToString();
        }

        [Required]
        [Key]
        [MaxLength(39)]
        public string ChargePointId { get; set; }

        [Required]
        [EnumDataType(typeof(ChargePointStatus))]
        public ChargePointStatus Status { get; set; }

        [MaxLength(4)]
        public string FloorLevel { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; }

        [ForeignKey(nameof(Location))]
        public string LocationId { get; set; }

        public Location Location { get; set; }
    }
}