﻿using Traveller.Models.Vehicles.Enum;

namespace Traveller.Models.Vehicles.Contracts
{
    public interface ITrain : IVehicle
    {
        int PassangerCapacity { get; }

        decimal PricePerKilometer { get; }

        // Please, please, please implement me
        VehicleType Type { get; set; }

        int Carts { get; }
    }
}