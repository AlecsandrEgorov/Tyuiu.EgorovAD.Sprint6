using Tyuiu.EgorovAD.Sprint6.Task3.V5.Lib;
namespace Tyuiu.EgorovAD.Sprint6.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
       {
            { 30, -20,   7,  -8,   9 },
            { 32,  17, -14,  -7,  33 },
            { 19, -19, -13,  14, -20 },
            { 11,  30,  -1,  26,   6 },
            { 30, -15, -20,  -5,  15 }
                                     };

            int[,] res = ds.Calculate(matrix);

            int[,] wait = ds.Calculate(matrix);

            Assert.AreEqual(wait, res);

        }
    }
}
