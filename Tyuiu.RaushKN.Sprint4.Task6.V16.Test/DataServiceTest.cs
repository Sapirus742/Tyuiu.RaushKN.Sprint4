using Tyuiu.RaushKN.Sprint4.Task6.V16.Lib;

namespace Tyuiu.RaushKN.Sprint4.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            string[] res = ds.Calculate(array);
            string[] wait = { "Самолет", "Трамвай" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}