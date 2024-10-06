using Tyuiu.RaushKN.Sprint4.Task4.V8.Lib;

namespace Tyuiu.RaushKN.Sprint4.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,] { {1, 3, 2, 2, 5 }, 
                                         {6, 1, 5, 5, 2 },
                                         {1, 5, 4, 1, 4 },
                                         {4, 1, 4, 4, 5 },
                                         {4, 6, 1, 1, 4 } };

            int[,] res = ds.Calculate(matrix);

            int[,] wait = new int[,] { {1, 3, 1, 1, 5 },
                                       {1, 1, 5, 5, 1 },
                                       {1, 5, 1, 1, 1 },
                                       {1, 1, 1, 1, 5 },
                                       {1, 1, 1, 1, 1 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}