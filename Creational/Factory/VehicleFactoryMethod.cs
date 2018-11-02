using Creational.Factory.Models;

namespace Creational.Factory
{
    /// <summary>
    /// Define an interface for creating an object
    /// but let subclasses decide which class to instantiate. 
    /// Factory Methods are usually called within Template Methods.
    /// </summary>

    public class VanFactory : IVehicleFactory
    {
        public IVehiche SellVehiche() //template method
        {
            var vehicle = CreateVehiche();
            vehicle.CalculateCost();
            return vehicle;
        }

        public IVehiche CreateVehiche()
        {
            return new Van();
        }
    }

    public class MotoFactory : IVehicleFactory
    {
        public IVehiche CreateVehiche()
        {
            return new Moto();
        }
    }

    public class CarFactory : IVehicleFactory
    {
        public IVehiche CreateVehiche()
        {
            return new Car();
        }
    }
}
