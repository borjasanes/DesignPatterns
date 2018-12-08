using System;

namespace Creational.Factory.Method
{
    /// <summary>
    /// Define an interface for creating an object
    /// but let subclasses decide which class to instantiate. 
    /// </summary>
    public abstract class TokenFactoryMethod
    {
        public abstract string CreateToken();

    }

    public class FourDigitTokenFactory : TokenFactoryMethod
    {
        public override string CreateToken()
        {
            return new Random().Next(1000, 9999).ToString();
        }
    }

    public class GuidTokenFactory : TokenFactoryMethod
    {
        public override string CreateToken()
        {
            return Guid.NewGuid().ToString();
        }
    }

}
