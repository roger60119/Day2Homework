﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterShoppingCart;
using System.Collections.Generic;

namespace PotterShoppingCartTests
{
    [TestClass]
    public class PotterShoppingCartTest
    {
        [TestMethod]
        public void Buy_1_EP_Total_Should_Be_100()
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
    }
}