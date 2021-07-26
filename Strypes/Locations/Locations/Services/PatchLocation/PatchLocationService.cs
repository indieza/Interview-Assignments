// <copyright file="PatchLocationService.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Services.PatchLocation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    public class PatchLocationService : IPatchLocationService
    {
        private readonly LocationsDbContext db;

        public PatchLocationService(LocationsDbContext db)
        {
            this.db = db;
        }

        public async Task<Tuple<bool, string>> PatchLocation(string locationId)
        {
            var targetLocation = await this.db.Locations.FirstOrDefaultAsync(x => x.LocationId == locationId);

            if (targetLocation != null)
            {
            }

            return Tuple.Create(false, $"There is no Location with ID: {locationId}");
        }
    }
}