using Tyuiu.RaushKN.Sprint4.Task2.V8.Lib;

namespace Tyuiu.RaushKN.Sprint4.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = new int[11] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
            int res = ds.Calculate(array);

            int wait = 33;

            Assert.AreEqual(wait, res);
         }
    }
}