using Tyuiu.BalinVV.Sprint1.Task3.V10.Lib;
namespace Tyuiu.BalinVV.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            var ds = new DataService();
            Assert.AreEqual(ds.NumberToMoney(236), "23.6 руб. — это 23 руб. 60 коп.");
        }
    }
}

