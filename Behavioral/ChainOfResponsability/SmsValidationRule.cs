using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.ChainOfResponsability
{
    /// <summary>
    /// Avoid coupling the sender of a request to its receiver by giving more than one object
    /// a chance to handle the request. 
    /// Chain the receiving objects and pass the request along the chain until
    /// an object handles it.
    /// </summary>
    public abstract class SmsValidationRule
    {
        protected SmsValidationRule NextRule;

        public void SetNext(SmsValidationRule rule)
        {
            NextRule = rule;
        }

        public abstract bool IsValid(SmsValidation smsValidation);
    }

    public class AttemptsRule : SmsValidationRule
    {
        private const int MaxAttempts = 5;

        public override bool IsValid(SmsValidation smsValidation)
        {
            if (smsValidation.Attempts >= MaxAttempts)
            {
                return false;
            }

            return NextRule?.IsValid(smsValidation) ?? true;
        }
    }

    public class ValidCodeRule : SmsValidationRule
    {
        public override bool IsValid(SmsValidation smsValidation)
        {
            if (smsValidation.UserInput != smsValidation.Code)
            {
                return false;
            }

            return NextRule?.IsValid(smsValidation) ?? true;
        }
    }

    public class ExpiredRule : SmsValidationRule
    {
        private const int ExpirationMinutes = -30;

        public override bool IsValid(SmsValidation smsValidation)
        {
            if (smsValidation.Sent < DateTime.UtcNow.AddMinutes(ExpirationMinutes))
            {
                return false;
            }

            return NextRule?.IsValid(smsValidation) ?? true;
        }
    }

    public class SmsValidation
    {
        public string Code { get; set; }
        public int Attempts { get; set; }
        public string UserInput { get; set; }
        public DateTime Sent { get; set; }
    }
}
