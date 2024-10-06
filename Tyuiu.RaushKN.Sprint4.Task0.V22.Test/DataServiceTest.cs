using Tyuiu.RaushKN.Sprint4.Task0.V22.Lib;

namespace Tyuiu.RaushKN.Sprint4.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumOddArrEl()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            int res = ds.GetSumOddArrEl(array);
            int wait = 46;

            Assert.AreEqual(wait, res);
        }
    }
}