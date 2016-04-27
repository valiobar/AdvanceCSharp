namespace Problem_8.Lego_Blocks
{
    using System;
    using System.Linq;

    class Program
    {
        private static int rows;

        private static int[][] firstBlock;

        private static int[][] secondBlock;

        private static bool isBlockMatch;

        static void Main()
        {
            FormBlocks();
            isBlockMatch = CheckIfMatch();
            PrintResult();
        }

        private static void FormBlocks()
        {
            rows = int.Parse(Console.ReadLine());
            firstBlock = new int[rows][];
            secondBlock = new int[rows][];
            for (int i = 0; i < rows * 2; i++)
            {
                if (i < rows)
                {
                    firstBlock[i] =
                        Console.ReadLine()
                            .Trim()
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
                }
                else
                {
                    secondBlock[i - rows] =
                        Console.ReadLine()
                            .Trim()
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
                }
            }
        }

        private static bool CheckIfMatch()
        {
            bool isBlockMatch = false;
            int rectangleWidth = firstBlock[0].Length + secondBlock[0].Length;
            for (int i = 1; i < rows; i++)
            {
                isBlockMatch = firstBlock[i].Length + secondBlock[i].Length == rectangleWidth;
            }
            return isBlockMatch;
        }

        private static void PrintResult()
        {
            if (!isBlockMatch)
            {
                int totalCells = 0;
                for (int i = 0; i < rows; i++)
                {
                    totalCells += firstBlock[i].Length + secondBlock[i].Length;
                }
                Console.WriteLine(string.Format("The total number of cells is: {0}", totalCells));
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine(
                        string.Format("[{0}, {1}]",
                        string.Join(", ", firstBlock[i]),
                        string.Join(", ", secondBlock[i].Reverse())));
                }
            }
        }
    }
}
