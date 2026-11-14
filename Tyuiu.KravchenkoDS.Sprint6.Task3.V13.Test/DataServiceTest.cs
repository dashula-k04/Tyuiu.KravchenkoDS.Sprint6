using Tyuiu.KravchenkoDS.Sprint6.Task3.V13.Lib;



namespace Tyuiu.KravchenkoDS.Sprint6.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5]
               { { -7, 34, -2, 25, 5 },
                { -16, -12, 30, -3, 17 },
                { 3, -15, 12, 5, -5 },
                { 17, 22, -3, 32, -11 },
                { 9, 28, 1, -9, -2} };

            int[,] res = ds.Calculate(matrix);

            int[,] wait = new int[5, 5]
               { {   3, -15, 12,   5,  -5 },
                { -16, -12, 30,  -3,  17 },
                {  17,  22, -3, 32, -11 },
                {   9,  28,  1,  -9,  -2 },
                { -7,  34, -2,  25,   5 } };

            CollectionAssert.AreEqual(wait, res);
        }


    }
}

