using Tyuiu.PautovaMO.Sprint6.Task0.V22.Lib;
namespace Tyuiu.PautovaMO.Sprint6.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds=new DataService();
            double res = ds.Calculate(3);
            double wait=32.580;
            Assert.AreEqual(wait,res);
        }
    }
}
