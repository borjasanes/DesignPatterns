
using System;

namespace Creational.Factory.Simple
{
    /// <summary>
    /// Encapsulate the class instantiation in one place
    /// 
    /// Violates OPEN CLOSE principle when adding more types.
    /// </summary>
    public static class TokenFactory
    {
        public static string GetToken(TokenType type)
        {
            switch (type)
            {
                case TokenType.FourDigitsCode:
                    return new Random().Next(1000,9999).ToString();
                case TokenType.Guid:
                    return Guid.NewGuid().ToString();
                default:
                    return null;
            }
        }
    }

    public enum TokenType
    {
        FourDigitsCode,
        Guid
    }
}
