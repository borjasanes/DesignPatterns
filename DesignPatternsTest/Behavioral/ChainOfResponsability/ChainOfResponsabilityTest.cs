using System;
using System.Collections.Generic;
using System.Text;
using Behavioral.ChainOfResponsability;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsTest.Behavioral.ChainOfResponsability
{
    [TestClass]
    public class ChainOfResponsabilityTest
    {
        private readonly SmsValidationRule _smsValidationRule;

        public ChainOfResponsabilityTest()
        {
            _smsValidationRule = new AttemptsRule();
            var expiredRule = new ExpiredRule();
            var validCodeRule = new ValidCodeRule();

            _smsValidationRule.SetNext(expiredRule);
            expiredRule.SetNext(validCodeRule);
        }

        [TestMethod]
        public void Given_ASmsValidation_When_MaxAttemps_Should_BeNotValid()
        {
            var smsValidation = new SmsValidation
            {
                Code = "5500",
                Attempts = 6,
                UserInput = "5501",
                Sent = DateTime.UtcNow.AddMinutes(-10)
            };

            Assert.IsFalse(_smsValidationRule.IsValid(smsValidation));
        }

        [TestMethod]
        public void Given_ASmsValidation_When_InvalidCode_Should_BeNotValid()
        {
            var smsValidation = new SmsValidation
            {
                Code = "5500",
                Attempts = 0,
                UserInput = "5501",
                Sent = DateTime.UtcNow.AddMinutes(-10)
            };

            Assert.IsFalse(_smsValidationRule.IsValid(smsValidation));
        }

        [TestMethod]
        public void Given_ASmsValidation_When_Valid_Should_ReturnValid()
        {
            var smsValidation = new SmsValidation
            {
                Code = "5500",
                Attempts = 0,
                UserInput = "5500",
                Sent = DateTime.UtcNow.AddMinutes(-10)
            };

            Assert.IsTrue(_smsValidationRule.IsValid(smsValidation));
        }
    }
}
