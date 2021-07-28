// <copyright file="PutChargePointInputModel.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.ViewModels.PutChargePoint.InputModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class PutChargePointInputModel
    {
        [Required]
        [MaxLength(39)]
        public string LocationId { get; set; }

        public ICollection<ChargePointInputModel> ChargePoints { get; set; } =
            new HashSet<ChargePointInputModel>();
    }
}