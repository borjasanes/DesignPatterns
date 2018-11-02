using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Singleton
{
    public sealed class VehicleSingletonThreadSafe
    {
        private static readonly Lazy<VehicleSingletonThreadSafe> Lazy =
            new Lazy<VehicleSingletonThreadSafe>(() => new VehicleSingletonThreadSafe());

        public static VehicleSingletonThreadSafe Instance => Lazy.Value;

        private VehicleSingletonThreadSafe()
        {
        }
    }
}
