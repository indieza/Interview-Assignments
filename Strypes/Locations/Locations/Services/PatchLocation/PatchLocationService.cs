// <copyright file="PatchLocationService.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Services.PatchLocation
{
    using System;
    using System.Threading.Tasks;

    using Locations.Models.Enums;
    using Locations.ViewModels.PatchLocation.InputModel;

    using Microsoft.EntityFrameworkCore;

    public class PatchLocationService : IPatchLocationService
    {
        private readonly LocationsDbContext db;

        public PatchLocationService(LocationsDbContext db)
        {
            this.db = db;
        }

        public async Task<Tuple<bool, string>> PatchLocation(string locationId, PatchLocationInputModel model)
        {
            var targetLocation = await this.db.Locations.FirstOrDefaultAsync(x => x.LocationId == locationId);

            if (targetLocation != null)
            {
                if (model.Address != null)
                {
                    targetLocation.Address = model.Address;
                }

                if (model.City != null)
                {
                    targetLocation.City = model.City;
                }

                if (model.Country != null)
                {
                    targetLocation.Country = model.Country;
                }

                if (model.Name != null)
                {
                    targetLocation.Name = model.Name;
                }

                if (model.PostalCode != null)
                {
                    targetLocation.PostalCode = model.PostalCode;
                }

                if (model.Type != null)
                {
                    targetLocation.Type = (LocationType)model.Type;
                }

                targetLocation.LastUpdated = DateTime.UtcNow;

                this.db.Locations.Update(targetLocation);
                await this.db.SaveChangesAsync();

                return Tuple.Create(true, $"Successfully update a Location with ID: {locationId}");
            }

            return Tuple.Create(false, $"There is no Location with ID: {locationId}");
        }
    }
}