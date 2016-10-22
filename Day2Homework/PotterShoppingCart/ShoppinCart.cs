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
            switch(books.Count)
            {
                case 2:
                    return 100 * books.Count * 0.95;
                case 3:
                    return 100 * books.Count * 0.9;
                case 4:
                    return 100 * books.Count * 0.8;
                case 5:
                    return 100 * books.Count * 0.75;
                default:
                    return 100 * books.Count;
            }
        }
    }
}