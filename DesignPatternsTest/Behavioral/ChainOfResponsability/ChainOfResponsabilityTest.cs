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

            SmsValidationRule attemptsRule = new AttemptsRule();
            attemptsRule.SetNext(new ExpiredRule());
            attemptsRule.SetNext(new ValidCodeRule());

            Assert.IsFalse(attemptsRule.IsValid(smsValidation));
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

            SmsValidationRule attemptsRule = new AttemptsRule();
            attemptsRule.SetNext(new ExpiredRule());
            attemptsRule.SetNext(new ValidCodeRule());

            Assert.IsFalse(attemptsRule.IsValid(smsValidation));
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

            SmsValidationRule attemptsRule = new AttemptsRule();
            attemptsRule.SetNext(new ExpiredRule());
            attemptsRule.SetNext(new ValidCodeRule());

            Assert.IsTrue(attemptsRule.IsValid(smsValidation));
        }
    }
}
