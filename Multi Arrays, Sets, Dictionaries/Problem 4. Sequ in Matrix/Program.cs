
namespace Problem_4.Sequ_in_Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static List<string> longestSequence = new List<string>();
       private static int maxCount = longestSequence.Count;
        static void Main()
        {
           string[,] inputMatrix = CreateInputMatrix();
           
            for (int i = 0; i < inputMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < inputMatrix.GetLength(1) - 1; j++)
                {
                     FindLongestSequence(i, j, inputMatrix);

                }
            }
            Console.WriteLine(string.Join(", ",longestSequence));
        }
        private static string[,] CreateInputMatrix()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] inputMatrix = new string[rows, cols];

            for (int i = 0; i < inputMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < inputMatrix.GetLength(1); j++)
                {
                    inputMatrix[i, j] = Console.ReadLine();
                }
            }
            return inputMatrix;
        }

        private static void FindLongestSequence(int row, int col, string[,] inputMatrix)
        {
           
            List<string> currentSequence = new List<string>();
            for (int i = col; i <inputMatrix.GetLength(1); i++)
            {
                if (currentSequence.Count==0||currentSequence.Last()==inputMatrix[row,i])
                {
                    currentSequence.Add(inputMatrix[row,i]);
                }
            }
            if (currentSequence.Count>longestSequence.Count)
            {
                longestSequence = currentSequence;
            }
            currentSequence = new List<string>();
            for (int i = row; i < inputMatrix.GetLength(0); i++)
            {
                if (currentSequence.Count == 0 || currentSequence.Last() == inputMatrix[row, col])
                {
                    currentSequence.Add(inputMatrix[i, col]);
                }
            }
            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = currentSequence;
            }
            currentSequence = new List<string>();
            for (int i = row,j=col; i < inputMatrix.GetLength(0)&&j<inputMatrix.GetLength(1); i++,j++)
            {
                if (currentSequence.Count == 0 || currentSequence.Last() == inputMatrix[i, j])
                {
                    currentSequence.Add(inputMatrix[i, j]);
                }
            }
            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = currentSequence;
            }
            currentSequence = new List<string>();

            for (int i = row, j = col; i < inputMatrix.GetLength(0) && j < 0; i++, j--)
            {
                if (currentSequence.Count == 0 || currentSequence.Last() == inputMatrix[i,j])
                {
                    currentSequence.Add(inputMatrix[i, j]);
                }
            }
            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence = currentSequence;
            }
            currentSequence = new List<string>();


        }
    }
}
