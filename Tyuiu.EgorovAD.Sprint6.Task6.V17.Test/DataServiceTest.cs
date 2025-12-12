using Tyuiu.EgorovAD.Sprint6.Task6.V17.Lib;
namespace Tyuiu.EgorovAD.Sprint6.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = $@"C:\DataSprint5\InPutDataFileTask6V17.txt";

            string res = ds.CollectTextFromFile(path);

            string wait = "wFrlYaZtHI XuLENkL BV ltxrhBXm HbJcPW";
            Assert.AreEqual(wait, res);
        }
    }
}
