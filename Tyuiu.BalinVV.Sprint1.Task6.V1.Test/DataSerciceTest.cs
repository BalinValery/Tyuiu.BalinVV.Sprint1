using Tyuiu.BalinVV.Sprint1.Task6.V1.Lib;
namespace Tyuiu.BalinVV.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataSerciceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.SymbolCode("1");
            Assert.AreEqual("49", res);
        }
    }
}

