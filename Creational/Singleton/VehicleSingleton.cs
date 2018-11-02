using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Singleton
{
    /// <summary>
    /// Ensure a class has only one instance
    /// and provide a global point of access to it.
    /// </summary>
    public sealed class VehicleSingleton
    {
        private VehicleSingleton() { }

        public static VehicleSingleton Instance { get; } = new VehicleSingleton();

        public string Name { get; set; }
    }
}
