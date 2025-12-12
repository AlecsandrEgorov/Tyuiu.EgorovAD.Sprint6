using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EgorovAD.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            
                int rows = matrix.GetLength(0) + 1;
                int cols = matrix.Length / rows;

                // Проверяем, что матрица достаточно большая для сортировки
                if (rows < 2) return matrix;

                // Создаем копию матрицы, чтобы не изменять оригинал
                int[,] result = (int[,])matrix.Clone();

                // Сортируем по третьему столбцу (индекс 2)
                int columnIndex = 2;

                // Проверяем, что столбец существует
                if (columnIndex >= cols) return result;

                // Используем сортировку пузырьком для строк
                for (int i = 0; i < rows - 1; i++)
                {
                    for (int j = 0; j < rows - i - 1; j++)
                    {
                        // Сравниваем значения в указанном столбце
                        if (result[j, columnIndex] > result[j + 1, columnIndex])
                        {
                            // Меняем строки местами
                            SwapRows(result, j, j + 1);
                        }
                    }
                }

                return result;
        }

          // Метод для обмена двух строк матрицы
         private void SwapRows(int[,] matrix, int row1, int row2)
        {
            int cols = matrix.GetLength(1);

            for (int col = 0; col < cols; col++)
            {
                int temp = matrix[row1, col];
                matrix[row1, col] = matrix[row2, col];
                matrix[row2, col] = temp;
            }
        }

    }
    
}
