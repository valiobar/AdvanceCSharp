

namespace Problem_1.Fill_the_Matrix
{
    using System;

    class Program
    {
       

        static void Main()
        {
            int[,] matrix=new int[4,4];
            FillMatrixPatternA(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();
            FillMatrixPatternB(matrix);
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "|");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrixPatternA(int[,] matrix) 
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j <matrix.GetLength(0); j++)
                {
                    matrix[j, i] = (j + 1) + i * 4;
                }
            }
        }
        private static void FillMatrixPatternB(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (i==0||i==2)
                    {
                        matrix[j, i] = (j + 1) + i * 4;
                    }
                    else
                    {
                        matrix[3-j, i] = (j + 1) + i * 4;
                    }
                    
                }
            }
        }
    }
}
