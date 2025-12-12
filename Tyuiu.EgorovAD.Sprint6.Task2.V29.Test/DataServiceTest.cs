using Tyuiu.EgorovAD.Sprint6.Task2.V29.Lib;
namespace Tyuiu.EgorovAD.Sprint6.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x1 = 4;
            int y1 = 5;

            double[] res = ds.GetMassFunction(x1, y1);

            double[] wait = ds.GetMassFunction(x1, y1);

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
