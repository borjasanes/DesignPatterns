using System;
using Creational.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Creational.Builder
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        [DataRow("name","phone")]
        public void Given_AContact_When_NameAndPhone_Should_Create(string name, string phone)
        {
            var sut = ContactBuilder.AContactBuilder()
                .WithName(name)
                .WithPhone(phone)
                .Build();

            Assert.AreEqual(name, sut.Name);
            Assert.AreEqual(phone, sut.Phone);
        }
    }
}
