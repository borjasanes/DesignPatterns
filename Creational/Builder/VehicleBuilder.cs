using Creational.Builder.Models;

namespace Creational.Builder
{
    /// <summary>
    /// Separate the construction of a complex object from its representation
    /// so that the same construction process can create different representations.
    /// </summary>
    public class VehicleBuilder
    {
        private static int Wheels { get; set; }
        private static int Doors { get; set; }

        public static VehicleBuilder AVehicleBuilder()
        {
            return new VehicleBuilder();
        }

        public VehicleBuilder WithWheels(int wheels)
        {
            Wheels = wheels;
            return this;
        }

        public VehicleBuilder WithDoors(int doors)
        {
            Doors = doors;
            return this;
        }

        public Vehicle Build()
        {
            return new Vehicle
            {
                Wheels = Wheels,
                Doors = Doors
            };
        }
    }
}