using System.Text;
using System.IO;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EgorovAD.Sprint6.Task5.V1.Lib
{
    public class DataService : ISprint6Task5V1
    {
        public int len;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] array = new double[len];

            int index = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    array[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            array = array.Where(val  => val > 0).ToArray();
            return array;



        }
    }
}
