using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeShopTests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void TotalPriceTest()
        {
            //arrange
            CoffeeShopPOS.Models.Order o = new CoffeeShopPOS.Models.Order();
            CoffeeShopPOS.Models.Drink drink1 = new CoffeeShopPOS.Models.Drink();
            drink1.Name = "TEA";
            drink1.Price = 1m;

            CoffeeShopPOS.Models.Drink drink2 = new CoffeeShopPOS.Models.Drink();
            drink2.Name = "COFFEE";
            drink2.Price = 1m;

            o.Drinks.Add(drink1);
            o.Drinks.Add(drink2);
            //act
            var result = o.TotalPrice;

            //assert
            Assert.IsTrue(result == 2, "It should have been 2");


        }
    }
}
