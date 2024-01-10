﻿namespace Mango.Services.ShoppingCartAPI.Models.Dto
{
    public class CartHeadersDto
    {
        public int CartHeaderId { get; set; }
        public string? UserId { get; set; }
        public string? CouponCode { get; set; }
        public double Discount { get; }
        public double CartTotal { get; set; }
    }
}
