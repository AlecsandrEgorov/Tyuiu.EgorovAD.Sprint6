using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EgorovAD.Sprint6.Task4.V13.Lib
{
    public class DataService : ISprint6Task4V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array;

            int len = stopValue - startValue + 1;
            array = new double[len];

            double y;

            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                y = Math.Round(3 * i + 2 - ((2 * i - i) / (Math.Cos(i) + 1)), 2);
                array[count] = y;
                count++;
            }
            return array; 
        }
    }
}
