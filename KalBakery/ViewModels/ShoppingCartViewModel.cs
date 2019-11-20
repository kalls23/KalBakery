using System;
using System.Collections.Generic;
using KalBakery.Models;

namespace KalBakery.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }

        public decimal ShoppingCartTotal { get; set; }
    }
}