using Tyuiu.PautovaMO.Sprint6.Task2.V16.Lib;
namespace Tyuiu.PautovaMO.Sprint6.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = -36.41;   // x = -5
            valueWaitArray[1] = -22.07;   // x = -4
            valueWaitArray[2] = 5.68;   // x = -3
            valueWaitArray[3] = 16.72;    // x = -2
            valueWaitArray[4] = 8.35;    // x = -1
            valueWaitArray[5] = -0.50;    // x = 0
            valueWaitArray[6] = 9.63;    // x = 1
            valueWaitArray[7] = 16.29;   // x = 2
            valueWaitArray[8] = 5.01;   // x = 3
            valueWaitArray[9] = -22.40;   // x = 4
            valueWaitArray[10] = -36.30;  // x = 5

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
