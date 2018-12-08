using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Decorator
{
    public class Coupon
    {
        public string Color { get; set; }
        public long BaseDiscount { get; set; }
        public string Title { get; set; }

        public double CalculateDiscount()
        {
            return BaseDiscount;
        }
    }

    public class CouponBio : Coupon
    {
        public new double CalculateDiscount()
        {
            return base.CalculateDiscount() * .15;
        }
    }

    public class CouponVegan : Coupon
    {
        public new double CalculateDiscount()
        {
            return base.CalculateDiscount() * .20;
        }
    }
}
