using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Singleton
{
    /// <summary>
    /// Singleton with lock to be thread safe
    /// </summary>
    public class VehicleSingletonTheadSafe
    {
        private VehicleSingletonTheadSafe() { }

        //the variable is declared to be volatile to ensure that assignment 
        //to the instance variable completes before the instance variable can be accessed
        private static volatile VehicleSingletonTheadSafe _instance;
        private static readonly object SyncLock = new object();

        //double check locking pattern
        public static VehicleSingletonTheadSafe Instance
        {
            get
            {
                if (_instance != null) return _instance;

                lock (SyncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new VehicleSingletonTheadSafe();
                    }
                }
                return _instance;
            }
        }
    }
}
