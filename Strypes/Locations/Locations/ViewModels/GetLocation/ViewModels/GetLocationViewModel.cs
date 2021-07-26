// <copyright file="GetLocationViewModel.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.ViewModels.GetLocation.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.Models.Enums;

    public class GetLocationViewModel
    {
        public string LocationId { get; set; }

        public LocationType Type { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}