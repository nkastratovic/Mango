﻿namespace Mango.Services.ShoppingCartAPI.Models.Dto
{
    public class CartDto
    {
        public CartHeadersDto CartHeader { get; set; }
        public IEnumerable<CartDetailsDto>? CardDetailes { get; set; }
    }
}
