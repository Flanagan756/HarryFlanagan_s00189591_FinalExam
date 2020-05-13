using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HarryFlanagan_s00189591;

namespace IncreasePriceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Phone p1 = new Phone();
            decimal expectedPrice = 220m;
            //Act
            p1.IncreasePrice(200, 10);
            //Assert
            Assert.AreEqual(expectedPrice, p1.Price);
        }
    }
}
