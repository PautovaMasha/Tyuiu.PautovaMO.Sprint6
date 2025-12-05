using Tyuiu.PautovaMO.Sprint6.Task4.V15.Lib;
namespace Tyuiu.PautovaMO.Sprint6.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray = new double[len];
            valueWaitArray[0] = 3.30;     // x = -5
            valueWaitArray[1] = -12.37;   // x = -4  
            valueWaitArray[2] = -14.02;   // x = -3
            valueWaitArray[3] = -5.57;    // x = -2
            valueWaitArray[4] = 0.65;     // x = -1
            valueWaitArray[5] = 0.00;     // x = 0
            valueWaitArray[6] = -0.65;    // x = 1
            valueWaitArray[7] = 5.57;     // x = 2
            valueWaitArray[8] = 14.02;    // x = 3
            valueWaitArray[9] = 12.37;    // x = 4
            valueWaitArray[10] = -3.30;   // x = 5

            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
