// <copyright file="IGetLocationService.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Services.GetLocation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.ViewModels.GetLocation.ViewModels;

    public interface IGetLocationService
    {
        Task<Tuple<bool, GetLocationViewModel>> GetLocation(string locationId);
    }
}