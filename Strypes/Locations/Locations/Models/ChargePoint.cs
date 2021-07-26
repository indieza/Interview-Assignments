// <copyright file="ChargePoint.cs" company="Locations">
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

    public class ChargePoint
    {
        public ChargePoint()
        {
            this.CharegPointId = Guid.NewGuid().ToString();
        }

        [Required]
        [Key]
        public string CharegPointId { get; set; }

        [Required]
        [EnumDataType(typeof(ChargePointStatus))]
        public ChargePointStatus Status { get; set; }

        [MaxLength(4)]
        public string FloorLevel { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; }
    }
}