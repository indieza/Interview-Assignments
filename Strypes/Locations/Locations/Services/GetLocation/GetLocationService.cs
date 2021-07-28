// <copyright file="GetLocationService.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Services.GetLocation
{
    using System;
    using System.Threading.Tasks;

    using Locations.ViewModels.GetLocation.ViewModels;

    using Microsoft.EntityFrameworkCore;

    public class GetLocationService : IGetLocationService
    {
        private readonly LocationsDbContext db;

        public GetLocationService(LocationsDbContext db)
        {
            this.db = db;
        }

        public async Task<Tuple<bool, GetLocationViewModel>> GetLocation(string locationId)
        {
            var targetLocation = await this.db.Locations.FirstOrDefaultAsync(x => x.LocationId == locationId);

            if (targetLocation != null)
            {
                var viewModel = new GetLocationViewModel
                {
                    LocationId = targetLocation.LocationId,
                    Address = targetLocation.Address,
                    City = targetLocation.City,
                    Country = targetLocation.Country,
                    LastUpdated = targetLocation.LastUpdated,
                    Name = targetLocation.Name,
                    PostalCode = targetLocation.PostalCode,
                    Type = targetLocation.Type,
                };

                return Tuple.Create(true, viewModel);
            }

            return Tuple.Create(false, new GetLocationViewModel());
        }
    }
}