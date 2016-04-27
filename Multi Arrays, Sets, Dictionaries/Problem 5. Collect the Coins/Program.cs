
namespace Problem_5.Collect_the_Coins
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        private static int coins = 0;
        private static int wallHits=0;

        static void Main()
        {
            char[][] board = CreateBoard();
            Dictionary<char,int[]>movements=new Dictionary<char, int[]>();
            movements['V'] = new[] { 1, 0 };
            movements['^']= new[] { -1, 0 };
            movements['<']= new[] { 0, -1 };
            movements['>']= new[] { 0, 1 };
            ExecuteMovements(board,movements);
            Console.WriteLine("Coins collected: "+coins);
            Console.WriteLine("Walls hit: "+wallHits);
        }

        private static char[][] CreateBoard()
        {
            char[][] board = new char[4][];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                board[i] = Console.ReadLine().ToCharArray();
            }
            return board;
        }

        private static void ExecuteMovements(char[][] board,Dictionary<char,int[]> movements )
        {
            char[] moveArr = Console.ReadLine().ToCharArray();
            int row = 0;
            int col = 0;
            char currentPosition = board[row][col];
            for (int i = 0; i < moveArr.Length; i++)
            {
                if (currentPosition =='$')
                {
                    coins++;
                }
                var currentMove = movements[moveArr[i]];
                try
                {
                    currentPosition = board[row + currentMove[0]][col + currentMove[1]];
                    row = row + currentMove[0];
                    col =col+ currentMove[1];
                }
                catch (IndexOutOfRangeException)
                {

                    wallHits++;
                }
                

            }
        }

    }
}
