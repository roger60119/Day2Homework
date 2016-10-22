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
            if (books.Count == 2)
            {
                return 100 * books.Count * 0.95;
            }
            else if (books.Count == 3)
            {
                return 100 * books.Count * 0.9;
            }

            return 100 * books.Count;
        }
    }
}