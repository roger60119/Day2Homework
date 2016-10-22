using System;
using System.Collections.Generic;

namespace PotterShoppingCart
{
    public class ShoppinCart
    {
        public double TotalPrice;

        public ShoppinCart()
        {
        }

        public void AddToCart(List<HarryPotter> books)
        {
            this.TotalPrice = GetTotalPrice(books);
        }

        private double GetTotalPrice(List<HarryPotter> books)
        {
            return 100 * books.Count;
        }
    }
}