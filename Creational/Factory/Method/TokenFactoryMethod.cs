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
            var token = CreateToken();
            token = SanitizeToken(token);
            return token;
        }

        protected abstract string CreateToken();
        protected abstract string SanitizeToken(string token);
    }

    public class FourDigitTokenFactory : TokenFactoryMethod
    {
        protected override string CreateToken()
        {
            return new Random().Next(1000, 9999).ToString();
        }

        protected override string SanitizeToken(string token)
        {
            return token;
        }
    }

    public class GuidTokenFactory : TokenFactoryMethod
    {
        protected override string CreateToken()
        {
            return Guid.NewGuid().ToString();
        }

        protected override string SanitizeToken(string token)
        {
            return token.Remove('-').ToUpper();
        }
    }
}
