// <copyright file="WeatherForecastController.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Locations.Services.CreateLocation;
    using Locations.Services.PatchLocation;
    using Locations.ViewModels.CreateLocation.InputModels;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("api/locations")]
    public class LocationsController : ControllerBase
    {
        private readonly ICreateLocationService createLocationService;
        private readonly IPatchLocationService patchLocationService;

        public LocationsController(ICreateLocationService createLocationService, IPatchLocationService patchLocationService)
        {
            this.createLocationService = createLocationService;
            this.patchLocationService = patchLocationService;
        }

        [HttpPost]
        public async Task<string> Create(CreateLocationInputModel model)
        {
            if (this.ModelState.IsValid)
            {
                Tuple<bool, string> result = await this.createLocationService.CreateLocation(model);

                if (!result.Item1)
                {
                    return "Inner developed error, contact with support!";
                }
                else
                {
                    return result.Item2;
                }
            }
            else
            {
                return "Invalid input model!";
            }
        }

        [HttpPatch]
        public async Task<string> Patch(string locationId)
        {
            if (!string.IsNullOrEmpty(locationId) && !string.IsNullOrWhiteSpace(locationId))
            {
                Tuple<bool, string> result = await this.patchLocationService.PatchLocation(locationId);

                if (!result.Item1)
                {
                    return result.Item2;
                }
                else
                {
                    return result.Item2;
                }
            }
            else
            {
                return "Invalid input model!";
            }
        }
    }
}