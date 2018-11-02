using Creational.Factory.Models;

namespace Creational.Factory.Contracts
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