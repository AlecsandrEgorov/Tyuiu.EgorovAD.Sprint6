using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.EgorovAD.Sprint6.Task7.V26.Lib
{
    public class DataService : ISprint6Task7V26
    {
        public int[,] GetMatrix(string path)
        {
            {

                string[] lines = File.ReadAllLines(path);

                int rowCount = lines.Length;
                int colCount = lines[0].Split(';').Length;

                int[,] matrix = new int[rowCount, colCount];

                for (int i = 0; i < rowCount; i++)
                {
                    string[] values = lines[i].Split(';');
                    for (int j = 0; j < colCount; j++)
                    {
                        if (int.TryParse(values[j], out int num))
                        {
                            matrix[i, j] = num;
                        }
                    }
                }
                ModifySecondColumn(matrix);

                return matrix;

            }
        }
        private void ModifySecondColumn(int[,] matrix)
        {
            int columnIndex = 1; 

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                if (matrix[i, columnIndex] > 5)
                {
                    matrix[i, columnIndex] = 222;

                }
            }
        }
    }
}
