﻿using System;
namespace KalBakery.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }

        public Cake Cake { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }

        public ShoppingCartItem()
        {
        }
    }
}
