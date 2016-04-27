

namespace Matrix_shuffling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[,] inputMatrix = CreateInputMatrix();
          
            while (true)
            {
                string inpuString = Console.ReadLine();
                if (inpuString == "END")
                {
                    break;
                }
                string[] command = inpuString.Split();
                int[] commandArgs = new int[command.Length - 1];

                if (command[0] != "swap" || commandArgs.Length != 4)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                for (int i = 1, j = 0; i < command.Length; i++,j++)
                {
                    commandArgs[j] = int.Parse(command[i]);
                }

                ExecuteComand(commandArgs, inputMatrix);
            }
        }

        private static void ExecuteComand(int[] comandArgs, string[,] inputMatrix)
        {
            try
            {
                string tempValue = inputMatrix[comandArgs[0], comandArgs[1]];
                inputMatrix[comandArgs[0], comandArgs[1]] = inputMatrix[comandArgs[2], comandArgs[3]];
                inputMatrix[comandArgs[2], comandArgs[3]] = tempValue;
                PrintMatrix(inputMatrix);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid input!");
            }
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

        private static void PrintMatrix(string[,] matrix)
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
    }
}
