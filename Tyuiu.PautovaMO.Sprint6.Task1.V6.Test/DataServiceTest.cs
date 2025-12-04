using Tyuiu.PautovaMO.Sprint6.Task1.V6.Lib;

namespace Tyuiu.PautovaMO.Sprint6.Task1.V6.Test
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
            valueWaitArray[0] = 17.27;   // x = -5
            valueWaitArray[1] = 14.08;   // x = -4
            valueWaitArray[2] = 10.27;   // x = -3
            valueWaitArray[3] = 6.65;    // x = -2
            valueWaitArray[4] = 3.87;    // x = -1
            valueWaitArray[5] = 2.00;    // x = 0
            valueWaitArray[6] = -0.74;    // x = 1
            valueWaitArray[7] = -3.71;   // x = 2
            valueWaitArray[8] = -7.59;   // x = 3
            valueWaitArray[9] = -11.55;   // x = 4
            valueWaitArray[10] = -14.74;  // x = 5

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
