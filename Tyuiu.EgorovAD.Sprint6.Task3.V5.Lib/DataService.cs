using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EgorovAD.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] result = (int[,])matrix.Clone();
            int rows = result.GetLength(0);
            int cols = result.GetLength(1);

            // Сортировка пузырьком по 3-му столбцу (индекс 2)
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (result[j, 2] > result[j + 1, 2]) // ← сравниваем 3-й столбец
                    {
                        // Меняем строки местами ← ВЕСЬ цикл меняет всю строку!
                        for (int col = 0; col < cols; col++)
                        {
                            int temp = result[j, col];
                            result[j, col] = result[j + 1, col];
                            result[j + 1, col] = temp;
                        }
                    }
                }
            }

            return result;
        }

    }
    
    
}
