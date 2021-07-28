// <copyright file="ChargePointStatus.cs" company="Locations">
// Copyright (c) Locations. All rights reserved.
// </copyright>

namespace Locations.Models.Enums
{
    public enum ChargePointStatus
    {
        Available = 1,
        Blocked = 2,
        Charging = 3,
        Removed = 4,
        Reserved = 5,
        Unknown = 6,
    }
}