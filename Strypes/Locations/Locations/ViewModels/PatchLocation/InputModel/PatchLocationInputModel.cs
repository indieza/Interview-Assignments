// <copyright file="PatchLocationInputModel.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.ViewModels.PatchLocation.InputModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.Models.Enums;

    public class PatchLocationInputModel
    {
        [EnumDataType(typeof(LocationType))]
        public LocationType? Type { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(45)]
        public string Address { get; set; }

        [MaxLength(45)]
        public string City { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }

        [MaxLength(45)]
        public string Country { get; set; }

        // public DateTime LastUpdated { get; set; }
    }
}