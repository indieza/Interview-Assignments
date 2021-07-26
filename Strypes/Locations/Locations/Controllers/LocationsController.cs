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
    using Locations.Services.GetLocation;
    using Locations.Services.PatchLocation;
    using Locations.ViewModels.ApplicationMessages;
    using Locations.ViewModels.CreateLocation.InputModels;
    using Locations.ViewModels.Errors;
    using Locations.ViewModels.GetLocation.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("api/locations")]
    public class LocationsController : ControllerBase
    {
        private readonly ICreateLocationService createLocationService;
        private readonly IPatchLocationService patchLocationService;
        private readonly IGetLocationService getLocationService;

        public LocationsController(
            ICreateLocationService createLocationService,
            IPatchLocationService patchLocationService,
            IGetLocationService getLocationService)
        {
            this.createLocationService = createLocationService;
            this.patchLocationService = patchLocationService;
            this.getLocationService = getLocationService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateLocationInputModel model)
        {
            if (this.ModelState.IsValid)
            {
                Tuple<bool, string> result = await this.createLocationService.CreateLocation(model);

                if (!result.Item1)
                {
                    return new JsonResult(new ErrorMessageViewModel { Message = "Inner developed error, contact with support!" });
                }
                else
                {
                    return new JsonResult(new SuccessfullMesageViewModel { Message = result.Item2 });
                }
            }
            else
            {
                return new JsonResult(new ErrorMessageViewModel { Message = "Invalid input model!" });
            }
        }

        [HttpPatch]
        public async Task<IActionResult> Patch(string locationId)
        {
            if (!string.IsNullOrEmpty(locationId) && !string.IsNullOrWhiteSpace(locationId))
            {
                Tuple<bool, string> result = await this.patchLocationService.PatchLocation(locationId);

                if (!result.Item1)
                {
                    return new JsonResult(new ErrorMessageViewModel { Message = result.Item2 });
                }
                else
                {
                    return new JsonResult(new SuccessfullMesageViewModel { Message = result.Item2 });
                }
            }
            else
            {
                return new JsonResult(new ErrorMessageViewModel { Message = "Invalid input model!" });
            }
        }

        [HttpGet]
        [Route("/api/locations/{locationId?}")]
        public async Task<IActionResult> Get(string locationId)
        {
            if (!string.IsNullOrEmpty(locationId) && !string.IsNullOrWhiteSpace(locationId))
            {
                Tuple<bool, GetLocationViewModel> result = await this.getLocationService.GetLocation(locationId);

                if (!result.Item1)
                {
                    return new JsonResult(new ErrorMessageViewModel { Message = $"There is no Location with ID: {locationId}!" });
                }
                else
                {
                    return new JsonResult(result.Item2);
                }
            }
            else
            {
                return new JsonResult(new ErrorMessageViewModel { Message = "Invalid input model!" });
            }
        }
    }
}