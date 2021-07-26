﻿// <copyright file="IPatchLocationService.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Services.PatchLocation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IPatchLocationService
    {
        Task<Tuple<bool, string>> PatchLocation(string locationId);
    }
}