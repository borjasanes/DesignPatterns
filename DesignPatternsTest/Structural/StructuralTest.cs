using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Structural.Decorator;

namespace DesignPatternsTest.Structural
{
    [TestClass]
    public class StructuralTest
    {
        [TestMethod]
        public void Given_ACoupon_When_IsDecorated_Should_AddFunctionality()
        {
            var sut = new Coupon { BaseDiscount = 10, Color = "Red", Title = "Welcome" };

            Assert.AreEqual(10, sut.CalculateDiscount());

            var sut2 = new CouponBio(sut);

            Assert.AreEqual(20, sut2.CalculateDiscount());

            var sut3 = new CouponVegan(sut2); // apply 2 times coupon bio discount

            Assert.AreEqual(60, sut3.CalculateDiscount());
        }
    }
}
