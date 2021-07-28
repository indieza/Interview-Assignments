// <copyright file="PutChargePointService.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Services.PutChargePoint
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.Models;
    using Locations.Models.Enums;
    using Locations.ViewModels.PutChargePoint.InputModels;

    using Microsoft.EntityFrameworkCore;

    public class PutChargePointService : IPutChargePointService
    {
        private readonly LocationsDbContext db;

        public PutChargePointService(LocationsDbContext db)
        {
            this.db = db;
        }

        public async Task<Tuple<bool, string>> PutChargePoint(string locationId, PutChargePointInputModel model)
        {
            var targetLocation = await this.db.Locations.FirstOrDefaultAsync(x => x.LocationId == locationId);

            if (targetLocation != null)
            {
                var targetChargePoints = this.db.ChargePoints.Where(x => x.LocationId == locationId).ToList();

                var chargePointsToBeRemoved = targetChargePoints
                    .Where(x => !model.ChargePoints.Any(y => y.ChargePointId == x.ChargePointId))
                    .ToList();

                foreach (var chargePointToBeRemoved in chargePointsToBeRemoved)
                {
                    chargePointToBeRemoved.Status = ChargePointStatus.Removed;
                }

                this.db.ChargePoints.UpdateRange(chargePointsToBeRemoved);

                var chargePointsToBeAdded = model.ChargePoints
                    .Where(x => !targetChargePoints.Any(y => y.ChargePointId == x.ChargePointId))
                    .ToList();

                foreach (var chargePointToBeAdded in chargePointsToBeAdded)
                {
                    this.db.ChargePoints.Add(new ChargePoint
                    {
                        LocationId = model.LocationId,
                        FloorLevel = chargePointToBeAdded.FloorLevel,
                        LastUpdated = DateTime.UtcNow,
                        Status = chargePointToBeAdded.Status,
                    });
                }

                await this.db.SaveChangesAsync();
                return Tuple.Create(true, $"Successfully update a Location with ID: {locationId}");
            }

            return Tuple.Create(false, $"There is no Location with ID: {locationId}");
        }
    }
}