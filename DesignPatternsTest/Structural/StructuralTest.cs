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

            var sut2 = new CouponBio { BaseDiscount = 10, Color = "Red", Title = "Welcome Bio" };

            Assert.AreEqual(1.5, sut2.CalculateDiscount());
        }
    }
}
