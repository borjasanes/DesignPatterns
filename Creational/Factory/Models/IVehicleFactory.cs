namespace Creational.Factory.Models
{
    /// <summary>
    /// Provide an interface for creating families of related or dependent objects
    /// without specifying their concrete classes
    /// </summary>

    public interface IVehicleFactory
    {
        IVehiche CreateVehiche();

    }
}