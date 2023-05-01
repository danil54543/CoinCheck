using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoinCheck.Service.Implementation.Tests
{
    [TestClass()]
    public class CurrencyServiceTests
    {
        [TestMethod()]
        public  void GetTop7CoinTest()
        {
            //Arrange
            CurrencyService currencyService = new();
            int yy = 7;
            //Act
            var request = currencyService.GetTop7Coin();
            //Asssert
            Assert.AreEqual(7, request.Result.Coins.Count());
        }
    }
}