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

            string[] array = { "����������", "���������", "�������", "�����", "�������", "����������", "�����" };
            string[] res = ds.Calculate(array);
            string[] wait = { "�������", "�������" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}