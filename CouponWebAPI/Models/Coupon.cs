﻿namespace CouponWebAPI.Models
{
    public class Coupon
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; }
        public int DiscountAmount { get; set; }
        public int  MinAmount { get; set; }       
    }
}
