using Creational.Factory;
using Creational.Factory.Simple;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Factory
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        [DataRow(TokenType.Guid, 36)]
        [DataRow(TokenType.FourDigitsCode, 4)]
        public void Given_ATokenType_Shoul_BeValidLength(TokenType tokenType, int tokenLength)
        {
            var sut = TokenFactory.GetToken(tokenType);

            Assert.IsNotNull(sut);
            Assert.AreEqual(tokenLength, sut.Length);
        }
    }
}
