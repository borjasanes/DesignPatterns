using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Creational.Factory
{
    /// <summary>
    /// Define an interface for creating an object, but let subclasses decide which class to instantiate
    /// </summary>
    public static class VehicleFactory
    {
        public static IVehiche CreateVehiche(VehicleType type)
        {
            switch (type)
            {
                case VehicleType.Moto:
                    return new Moto();
                case VehicleType.Car:
                    return new Car();
                case VehicleType.Van:
                    return new Van();
                default:
                    return null;
            }
        }
    }
}
