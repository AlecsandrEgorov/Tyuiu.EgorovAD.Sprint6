using Tyuiu.EgorovAD.Sprint6.Task0.V19.Lib;
namespace Tyuiu.EgorovAD.Sprint6.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 3;
            double res = ds.Calculate(x);
            double wait = -1;
            Assert.AreEqual(wait, res);
        }
    }
}
