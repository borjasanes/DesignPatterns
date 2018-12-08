using System;

namespace Creational.Factory.Method
{
    /// <summary>
    /// Define an interface for creating an object
    /// but let subclasses decide which class to instantiate. 
    /// the Factory Method pattern uses inheritance
    /// and relies on a subclass to handle the desired object instantiation.
    /// </summary>
    public abstract class TokenFactoryMethod
    {
        public string GenetateToken()
        {
            return CreateToken();
        }

        protected abstract string CreateToken();

    }

    public class FourDigitTokenFactory : TokenFactoryMethod
    {
        protected override string CreateToken()
        {
            return new Random().Next(1000, 9999).ToString();
        }
    }

    public class GuidTokenFactory : TokenFactoryMethod
    {
        protected override string CreateToken()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
