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

            // Сортировка пузырьком по 3-му столбцу
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    // Сравниваем значения в 3-м столбце (индекс 2)
                    if (result[j, 2] > result[j + 1, 2])
                    {
                        // Меняем строки местами
                        for (int k = 0; k < cols; k++)
                        {
                            int temp = result[j, k];
                            result[j, k] = result[j + 1, k];
                            result[j + 1, k] = temp;
                        }
                    }
                }
            }

            return result;

        }
    }
    
}
