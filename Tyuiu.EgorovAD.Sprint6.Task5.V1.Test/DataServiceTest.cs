using Tyuiu.EgorovAD.Sprint6.Task5.V1.Lib;
namespace Tyuiu.EgorovAD.Sprint6.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask5V1.txt";

            double[] res = ds.LoadFromDataFile(path);

            double[] wait = { 1.0, 2.0, 3.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0};
            for(int i  = 0; i < res.Length; i++)
            {
                Assert.AreEqual(res[i], wait[i]);
            }
        }
    }
}
