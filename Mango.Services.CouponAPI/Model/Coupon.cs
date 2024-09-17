﻿using System.ComponentModel.DataAnnotations;

namespace Mango.Services.CouponAPI.Model
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string CouponName { get; set; }
        [Required]
        public double DiscountAmount { get; set; }
        public int MinAMount { get; set; }
        
         

    }
}
