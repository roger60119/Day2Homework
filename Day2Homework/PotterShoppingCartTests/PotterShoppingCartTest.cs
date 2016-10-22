using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System.Collections.Generic;

namespace PotterShoppingCartTests
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void Buy_1_EP1_Total_Should_Be_100()
        {
            //arrange
            ShoppinCart target = new ShoppinCart();
            List<HarryPotter> books = new List<HarryPotter>
            {
                new HarryPotter { Episode = "1" }
            };

            //act
            target.AddToCart(books);
            double actual = target.TotalPrice;

            //assert
            double expected = 100;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_1_EP1_And_1_EP2_Total_Should_Be_190()
        {
            //arrange
            ShoppinCart target = new ShoppinCart();
            List<HarryPotter> books = new List<HarryPotter>
            {
                new HarryPotter { Episode = "1" },
                new HarryPotter { Episode = "2" }
            };

            //act
            target.AddToCart(books);
            double actual = target.TotalPrice;

            //assert
            double expected = 190;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_1_EP1_And_1_EP2_And_1_EP3_Total_Should_Be_270()
        {
            //arrange
            ShoppinCart target = new ShoppinCart();
            List<HarryPotter> books = new List<HarryPotter>
            {
                new HarryPotter { Episode = "1" },
                new HarryPotter { Episode = "2" },
                new HarryPotter { Episode = "3" }
            };

            //act
            target.AddToCart(books);
            double actual = target.TotalPrice;

            //assert
            double expected = 270;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_1_EP1_And_1_EP2_And_1_EP3_And_1_EP4_Total_Should_Be_320()
        {
            //arrange
            ShoppinCart target = new ShoppinCart();
            List<HarryPotter> books = new List<HarryPotter>
            {
                new HarryPotter { Episode = "1" },
                new HarryPotter { Episode = "2" },
                new HarryPotter { Episode = "3" },
                new HarryPotter { Episode = "4" }
            };

            //act
            target.AddToCart(books);
            double actual = target.TotalPrice;

            //assert
            double expected = 320;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_1_EP1_And_1_EP2_And_1_EP3_And_1_EP4_And_1_EP5_Total_Should_Be_375()
        {
            //arrange
            ShoppinCart target = new ShoppinCart();
            List<HarryPotter> books = new List<HarryPotter>
            {
                new HarryPotter { Episode = "1" },
                new HarryPotter { Episode = "2" },
                new HarryPotter { Episode = "3" },
                new HarryPotter { Episode = "4" },
                new HarryPotter { Episode = "5" }
            };

            //act
            target.AddToCart(books);
            double actual = target.TotalPrice;

            //assert
            double expected = 375;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_1_EP1_And_1_EP2_And_2_EP3_Total_Should_Be_370()
        {
            //arrange
            ShoppinCart target = new ShoppinCart();
            List<HarryPotter> books = new List<HarryPotter>
            {
                new HarryPotter { Episode = "1" },
                new HarryPotter { Episode = "2" },
                new HarryPotter { Episode = "3" },
                new HarryPotter { Episode = "3" }
            };

            //act
            target.AddToCart(books);
            double actual = target.TotalPrice;

            //assert
            double expected = 370;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Buy_1_EP1_And_2_EP2_And_2_EP3_Total_Should_Be_460()
        {
            //arrange
            ShoppinCart target = new ShoppinCart();
            List<HarryPotter> books = new List<HarryPotter>
            {
                new HarryPotter { Episode = "1" },
                new HarryPotter { Episode = "2" },
                new HarryPotter { Episode = "2" },
                new HarryPotter { Episode = "3" },
                new HarryPotter { Episode = "3" }
            };

            //act
            target.AddToCart(books);
            double actual = target.TotalPrice;

            //assert
            double expected = 460;
            Assert.AreEqual(expected, actual);
        }
    }
}
