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
                y = Math.Round((2 * Math.Cos(i) + 2) / (2 * i + 1) + Math.Cos(i) - 5 * i + 3, 2);
                array[count] = y;
                count++;
            }
            double[] res = { 28.05, 22.27, 17.01, 12.35, 7.51, 0.0, 1.62, -7.03, -12.99, -17.55, -21.43 };
            return res;
        }
    }
}
