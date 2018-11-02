using Creational.Factory.Contracts;
using Creational.Factory.Method;
using Creational.Factory.Models;

namespace Creational.Factory.Abstract
{
    /// <summary>
    /// Provide an interface for creating families of related or dependent objects
    /// without specifying their concrete classes.
    /// </summary>
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

        public VanWithAbstractFactory(IVehicleFactory factory) :
            base(factory)
        { }
    }

    public class CarWithAbstractFactory :
        VehicleAbstractFactory
    {
        public CarWithAbstractFactory() :
            base(new CarFactory())
        { }

        public CarWithAbstractFactory(IVehicleFactory factory) :
            base(factory)
        { }
    }

    public class MotoWithAbstractFactory :
        VehicleAbstractFactory
    {
        public MotoWithAbstractFactory() :
            base(new MotoFactory())
        { }

        public MotoWithAbstractFactory(IVehicleFactory factory) :
            base(factory)
        { }
    }
}
