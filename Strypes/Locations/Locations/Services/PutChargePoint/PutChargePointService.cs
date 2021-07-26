// <copyright file="PutChargePointService.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Services.PutChargePoint
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.ViewModels.PutChargePoint.InputModels;

    public class PutChargePointService : IPutChargePointService
    {
        private readonly LocationsDbContext db;

        public PutChargePointService(LocationsDbContext db)
        {
            this.db = db;
        }

        public async Task<Tuple<bool, string>> PutChargePoint(string locationId, PutChargePointInputModel model)
        {
            throw new NotImplementedException();
        }
    }
}