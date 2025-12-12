using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EgorovAD.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            // Правильно получаем размеры матрицы
            int rows = matrix.GetLength(0);    // количество строк = 5
            int cols = matrix.GetLength(1);    // количество столбцов = 5

            // Создаем копию матрицы для сортировки
            int[,] result = (int[,])matrix.Clone();

            // Индекс столбца для сортировки (3-й столбец = индекс 2)
            int columnIndex = 2;

            // Проверяем, что столбец существует
            if (columnIndex >= cols)
            {
                // Если 3-го столбца нет, возвращаем исходную матрицу
                return result;
            }

            // Сортировка пузырьком по 3-му столбцу
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    // Сравниваем значения в 3-м столбце
                    if (result[j, columnIndex] > result[j + 1, columnIndex])
                    {
                        // Меняем строки местами
                        SwapRows(result, j, j + 1);
                    }
                }
            }

            return result;
        }

        // Метод для обмена строк
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
