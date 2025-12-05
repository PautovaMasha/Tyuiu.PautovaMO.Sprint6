using Tyuiu.PautovaMO.Sprint6.Task3.V12.Lib;
namespace Tyuiu.PautovaMO.Sprint6.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[3, 3]
            {
                { 1, 0, 3 },  // 2 заменено на 0
                { 4, 5, 6 }, 
                { 7, 8, 9 }   
            };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
