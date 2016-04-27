

namespace Problem_2.Maximal_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[,] matrix = CreateInputMatrix();
            Dictionary<int, int[,]> allSqares = new Dictionary<int, int[,]>();
            GetAll3X3Squares(matrix, allSqares);
            Console.WriteLine("sum = " + allSqares.Keys.Max());
            PrintMatrix(allSqares[allSqares.Keys.Max()]);
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

        private static int FindSquareSum(int elemenmtRow, int elememtCol, int[,] matrix)
        {
            int sqareSum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sqareSum += matrix[elemenmtRow + i, elememtCol + j];
                }
            }

            return sqareSum;
        }

        private static void GetAll3X3Squares(int[,] matrix, Dictionary<int, int[,]> allSqares)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i + 2 < matrix.GetLength(0) && j + 2 < matrix.GetLength(1))
                    {
                        allSqares.Add(FindSquareSum(i, j, matrix), GetSquare(i, j, matrix));
                    }
                }
            }
        }

        private static int[,] GetSquare(int elemenmtRow, int elememtCol, int[,] matrix)
        {
            int[,] square = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    square[i, j] = matrix[elemenmtRow + i, elememtCol + j];
                }
            }
            return square;
        }

        private static int[,] CreateInputMatrix()
        {
            int[] matrixsize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] inputMatrix = new int[matrixsize[0], matrixsize[1]];
            int[] inputNums = new int[inputMatrix.GetLength(1)];
            for (int i = 0; i < inputMatrix.GetLength(0); i++)
            {
                inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                {
                    inputMatrix[i, j] = inputNums[j];
                }
            }
            return inputMatrix;
        }
    }
}
