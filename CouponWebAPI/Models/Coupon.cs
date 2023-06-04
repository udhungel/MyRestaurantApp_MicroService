﻿using System.ComponentModel.DataAnnotations;

namespace CouponWebAPI.Models
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }

        [Required]
        public string CouponCode { get; set; }

        [Required]
        public int DiscountAmount { get; set; }
        public int  MinAmount { get; set; }       
    }
}
