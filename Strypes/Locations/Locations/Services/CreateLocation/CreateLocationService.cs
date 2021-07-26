// <copyright file="CreateLocationService.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Services.CreateLocation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.Models;
    using Locations.ViewModels.CreateLocation.InputModels;

    public class CreateLocationService : ICreateLocationService
    {
        private readonly LocationsDbContext db;

        public CreateLocationService(LocationsDbContext db)
        {
            this.db = db;
        }

        public async Task<Tuple<bool, string>> CreateLocation(CreateLocationInputModel model)
        {
            try
            {
                this.db.Locations.Add(new Location
                {
                    Type = model.Type,
                    Address = model.Address,
                    City = model.City,
                    Country = model.Country,
                    Name = model.Name,
                    PostalCode = model.PostalCode,
                    LastUpdated = DateTime.UtcNow,
                });

                await this.db.SaveChangesAsync();
                return Tuple.Create(true, "Successfully add a new Location");
            }
            catch (Exception ex)
            {
                return Tuple.Create(false, ex.Message);
            }
        }
    }
}