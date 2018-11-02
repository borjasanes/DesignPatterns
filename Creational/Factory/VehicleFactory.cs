using Creational.Factory.Models;

namespace Creational.Factory
{
    /// <summary>
    /// Encapsulate the class instantiation in one place
    /// 
    /// Violates OPEN CLOSE principle when adding more types.
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
