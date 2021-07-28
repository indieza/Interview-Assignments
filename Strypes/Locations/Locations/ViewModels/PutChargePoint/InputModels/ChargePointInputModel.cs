// <copyright file="ChargePointInputModel.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.ViewModels.PutChargePoint.InputModels
{
    using System.ComponentModel.DataAnnotations;

    using Locations.Models.Enums;

    public class ChargePointInputModel
    {
        [MaxLength(39)]
        public string ChargePointId { get; set; }

        [Required]
        [EnumDataType(typeof(ChargePointStatus))]
        public ChargePointStatus Status { get; set; }

        [MaxLength(4)]
        public string FloorLevel { get; set; }

        public string LocationId { get; set; }

        // [Required]
        // public DateTime LastUpdated { get; set; }
    }
}