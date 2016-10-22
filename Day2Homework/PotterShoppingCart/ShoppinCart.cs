using System;
using System.Collections.Generic;
using System.Linq;

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
            double totalPrice = 0;
            int index = 0;
            int booksCates = books.GroupBy(x => x.Episode).Count();
            while (booksCates != 0)
            {
                booksCates = books.GroupBy(x => x.Episode)
                    .Select(y => y.Skip(index).FirstOrDefault())
                    .Where(z => z != null).Count();

                totalPrice += GetDiscount(booksCates);
                index++;
            }

            return totalPrice;
        }

        private static double GetDiscount(int booksCates)
        {
            switch (booksCates)
            {
                case 2:
                    return 100 * booksCates * 0.95;
                case 3:
                    return 100 * booksCates * 0.9;
                case 4:
                    return 100 * booksCates * 0.8;
                case 5:
                    return 100 * booksCates * 0.75;
                default:
                    return 100 * booksCates;
            }
        }
    }
}