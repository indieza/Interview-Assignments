// <copyright file="IPutChargePointService.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Services.PutChargePoint
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.ViewModels.PutChargePoint.InputModels;

    public interface IPutChargePointService
    {
        Task<Tuple<bool, string>> PutChargePoint(string locationId, PutChargePointInputModel model);
    }
}