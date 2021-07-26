// <copyright file="ChargePointInputModel.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.ViewModels.PutChargePoint.InputModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.Models.Enums;

    public class ChargePointInputModel
    {
        [Required]
        [EnumDataType(typeof(ChargePointStatus))]
        public ChargePointStatus Status { get; set; }

        [MaxLength(4)]
        public string FloorLevel { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; }

        public string LocationId { get; set; }
    }
}