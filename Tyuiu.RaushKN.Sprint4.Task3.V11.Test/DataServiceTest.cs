using Tyuiu.RaushKN.Sprint4.Task3.V11.Lib;

namespace Tyuiu.RaushKN.Sprint4.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[,] { { 8, 6, 9, 4, 5, }, { 9, 4, 8, 5, 6, }, { 9, 7, 9, 8, 4, }, { 4, 6, 5, 7, 8, }, { 6, 6, 7, 6, 4, } };
            int res = ds.Calculate(array);
            int wait = 10;

            Assert.AreEqual(wait, res);
        }
    }
}