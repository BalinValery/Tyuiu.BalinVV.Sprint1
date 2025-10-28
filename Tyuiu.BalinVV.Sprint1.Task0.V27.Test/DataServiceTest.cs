using Tyuiu.BalinVV.Sprint1.Task0.V27.Lib;
namespace Tyuiu.BalinVV.Sprint1.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServieTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(22, res);

        }
    }
}