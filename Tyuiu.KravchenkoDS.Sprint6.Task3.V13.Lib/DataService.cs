using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.KravchenkoDS.Sprint6.Task3.V13.Lib
{
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            for (int i = 0; i < rows - 1; i++)
            {
              for (int j = 0; j < rows - i - 1; j++)
                {
                 if (matrix[j, 1] > matrix[j + 1, 1])
                    {
                      for (int m = 0; m < columns; m++)
                        {
                            int temp = matrix[j, m];
                            matrix[j, m] = matrix[j + 1, m];
                            matrix[j + 1, m] = temp;
                        }
                    }
                }
            }

            return matrix;
        }
    }
}
