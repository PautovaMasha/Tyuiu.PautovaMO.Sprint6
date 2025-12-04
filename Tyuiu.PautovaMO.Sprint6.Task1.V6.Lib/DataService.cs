using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PautovaMO.Sprint6.Task1.V6.Lib
{
    public class DataService : ISprint6Task1V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Abs(3*x-1) > 0.001)
                {
                    y = Math.Round(((Math.Sin(x) - 2 * x) / (3 * x - 1) + Math.Sin(x) - 3 * x + 2), 2);
                    valueArray[count] = y;
                    count++;
                }
                else
                {
                    valueArray[count] = 0;
                    count++;
                }
            }
            return valueArray;
        }
    }
}
