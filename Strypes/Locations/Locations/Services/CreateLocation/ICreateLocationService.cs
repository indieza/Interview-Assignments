// <copyright file="ICreateLocationService.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Services.CreateLocation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.ViewModels.CreateLocation.InputModels;

    public interface ICreateLocationService
    {
        Task<Tuple<bool, string>> CreateLocation(CreateLocationInputModel model);
    }
}