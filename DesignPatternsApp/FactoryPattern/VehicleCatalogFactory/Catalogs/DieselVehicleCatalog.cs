﻿using FactoryPattern.Models;
using FactoryPattern.Vehicles;

namespace FactoryPattern.VehicleCatalogFactory.Catalogs
{
    public class DieselVehicleCatalog : IVehicleCatalog
    {
        public Vehicle[] GetVehicles()
        {
            return new[] {
                new Vehicle() { Name = "diesel 1" },
                new Vehicle() { Name = "diesel 2" },
                new Vehicle() { Name = "diesel 3" }
            };
        }
    }
}
