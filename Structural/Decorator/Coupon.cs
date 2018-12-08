using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Decorator
{
    public interface ICoupon
    {
        string Color { get; set; }
        long BaseDiscount { get; set; }
        string Title { get; set; }
        double CalculateDiscount();
    }

    public class Coupon : ICoupon
    {
        public string Color { get; set; }
        public long BaseDiscount { get; set; }
        public string Title { get; set; }

        public double CalculateDiscount()
        {
            return BaseDiscount;
        }
    }

    public class CouponBio : ICoupon
    {
        private readonly ICoupon _coupon;

        public CouponBio(ICoupon coupon)
        {
            _coupon = coupon;
        }

        public string Color { get; set; }
        public long BaseDiscount { get; set; }
        public string Title { get; set; }

        public double CalculateDiscount()
        {
            return _coupon.CalculateDiscount() * 2;
        }
    }

    public class CouponVegan : ICoupon
    {
        private readonly ICoupon _coupon;

        public CouponVegan(ICoupon coupon)
        {
            _coupon = coupon;
        }

        public string Color { get; set; }
        public long BaseDiscount { get; set; }
        public string Title { get; set; }

        public double CalculateDiscount()
        {
            return _coupon.CalculateDiscount() * 3;
        }
    }
}
