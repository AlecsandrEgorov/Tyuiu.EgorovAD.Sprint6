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

            // Ожидаемый результат ПОСЛЕ сортировки по 3-му столбцу
            int[,] wait = new int[5, 5]
            {
        { 30, -15, -20,  -5,  15 }, // строка с -20 в 3-м столбце
        { 32,  17, -14,  -7,  33 }, // строка с -14 в 3-м столбце
        { 19, -19, -13,  14, -20 }, // строка с -13 в 3-м столбце
        { 11,  30,  -1,  26,   6 }, // строка с -1 в 3-м столбце
        { 30, -20,   7,  -8,   9 }  // строка с 7 в 3-м столбце
            };

            for (int i = 0; i < wait.GetLength(0); i++)
            {
                for (int j = 0; j < wait.GetLength(1); j++)
                {
                    Assert.AreEqual(wait[i, j], res[i, j]);
                }
            }
        
        }
    }
}
