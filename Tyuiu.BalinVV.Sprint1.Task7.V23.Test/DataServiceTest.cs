using Tyuiu.BalinVV.Sprint1.Task7.V23.Lib;
namespace Tyuiu.BalinVV.Sprint1.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();
            double x = 2, y = 4;
            var res = Math.Round( ds.Calculate(x, y), 3);
            double wait = -1.782;
            Assert.AreEqual(wait, res);
        }
    }
}
