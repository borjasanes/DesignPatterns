using Creational.Factory.Contracts;
using Creational.Factory.Method;
using Creational.Factory.Models;

namespace Creational.Factory.Abstract
{
    public abstract class VehicleAbstractFactory
    {
        private readonly IVehicleFactory _factory;

        protected VehicleAbstractFactory(IVehicleFactory factory)
        {
            _factory = factory;
        }

        public IVehiche CreateVehicle()
        {
            return _factory.CreateVehiche();
        }
    }

    public class VanWithAbstractFactory :
        VehicleAbstractFactory
    {
        public VanWithAbstractFactory() :
            base(new VanFactory())
        { }
    }

    public class CarWithAbstractFactory :
        VehicleAbstractFactory
    {
        public CarWithAbstractFactory() :
            base(new CarFactory())
        { }
    }

    public class MotoWithAbstractFactory :
        VehicleAbstractFactory
    {
        public MotoWithAbstractFactory() :
            base(new MotoFactory())
        { }
    }
}
