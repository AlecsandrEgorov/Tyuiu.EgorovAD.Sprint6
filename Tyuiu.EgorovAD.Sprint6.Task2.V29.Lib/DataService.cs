using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EgorovAD.Sprint6.Task2.V29.Lib
{
    public class DataService : ISprint6Task2V29
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
                y = (2 * Math.Cos(i) + 2) / (2 * i + 1) + Math.Cos(i) - 5 * i + 3;
                array[count] = y;
                count++;
            }
            return array;
        }
    }
}
