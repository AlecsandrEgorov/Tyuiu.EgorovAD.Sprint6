using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EgorovAD.Sprint6.Task3.V5.Lib
{
    public class DataService : ISprint6Task3V5
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] result = (int[,])matrix.Clone();
            int rows = result.GetLength(0);

            // Собираем значения из 3-го столбца
            int[] thirdColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                thirdColumn[i] = result[i, 2];
            }

            // Сортируем значения 3-го столбца
            Array.Sort(thirdColumn);

            // Записываем отсортированные значения обратно в 3-й столбец
            for (int i = 0; i < rows; i++)
            {
                result[i, 2] = thirdColumn[i];
            }

            return result;

        }
    }
    
}
