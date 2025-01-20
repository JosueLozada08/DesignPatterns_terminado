using DesignPatterns.Models;
using DesignPatterns.ModelBuilders;
using System;

namespace DesignPatterns.Factories
{
    public static class VehicleFactory
    {
        public static Vehicle CreateVehicle(string type)
        {
            return type switch
            {
                "Mustang" => new VehicleBuilder("Red", "Ford", "Mustang")
                                .AddDefaultProperties()
                                .Build(),
                "Explorer" => new VehicleBuilder("Blue", "Ford", "Explorer")
                                .AddDefaultProperties()
                                .Build(),
                "Escape" => new VehicleBuilder("Green", "Ford", "Escape")
                                .AddDefaultProperties()
                                .Build(),
                _ => throw new ArgumentException($"Tipo de vehículo desconocido: {type}")
            };
        }
    }
}
