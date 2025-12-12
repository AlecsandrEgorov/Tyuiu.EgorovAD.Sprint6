using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EgorovAD.Sprint6.Task1.V23.Lib
{
    public class DataService : ISprint6Task1V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array;

            int len = stopValue - startValue + 1;
            array = new double[len];

            int count = 0;
            for (int i = startValue; i <= stopValue; i++)  
            {
                double y = Math.Round(3.3 * Math.Sin(i) + 2.4 * i - 4.1 * i * Math.Cos(i), 2);
                array[count] = y;
                count++;
            }
            return array;
        }
    }
}
