namespace Creational
{
    public class VehicleBuilder
    {
        private int Wheels { get; set; }
        private int Doors { get; set; }

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