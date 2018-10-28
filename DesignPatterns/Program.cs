using Creational;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var vehicle = VehicleBuilder.AVehicleBuilder()
                .WithDoors(4)
                .WithWheels(4);


        }
    }
}
