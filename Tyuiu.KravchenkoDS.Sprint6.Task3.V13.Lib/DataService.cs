using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.KravchenkoDS.Sprint6.Task3.V13.Lib
{
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            for (int i = 0; i < rows - 1; i++)
            {
               for (int j = 0; j < rows - i - 1; j++)
                {
                   if (matrix[j, 1] > matrix[j + 1, 1])
                    {
                        int temp = matrix[j, 1];
                        matrix[j, 1] = matrix[j + 1, 1];
                        matrix[j + 1, 1] = temp;
                    }
                }
            }

            return matrix;
        }
    }
}

