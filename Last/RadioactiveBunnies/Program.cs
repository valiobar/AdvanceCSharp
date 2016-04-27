using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioactiveBunnies
{
    class Program
    {
        private static int[] playerPosition;
    
        static void Main(string[] args)
        {
            bool isGameOver = false;
            bool isGameOver2 = false;
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] bunnyLair = new string[matrixSize[0], matrixSize[1]];
            for (int i = 0; i < matrixSize[0]; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < matrixSize[1]; j++)
                {
                    bunnyLair[i, j] = line[j].ToString();
                    if (line[j].ToString() == "P")
                    {
                        playerPosition = new int[] { i, j };
                    }
                }
            }
            string directions = Console.ReadLine();
            for (int i = 0; i < directions.Length; i++)
            {
                if (isGameOver)
                {
                    break;
                }
                isGameOver = MovePlayer(bunnyLair, directions[i].ToString());
                isGameOver2 = MultiplyBunnys(bunnyLair);
            }
        }

        private static bool MovePlayer(string[,] lair, string direction)
        {
            bool isOut = false;
            int[] newPositio = playerPosition;
            switch (direction)
            {
                case "U":
                    newPositio[0]--;
                    break;

                case "D":
                    newPositio[0]++;
                    break;

                case "R":
                    newPositio[1]++;
                    break;

                case "L":
                    newPositio[1]--;
                    break;
            }
            for (int i = 0; i < newPositio.Length; i++)
            {
                if (newPositio[i] < 0 || newPositio[i] >= lair.GetLength(i))
                {
                    isOut = true;
                }
            }

            if (isOut)
            {
                PrintBunnyLair(lair);
                Console.WriteLine(string.Format("won: {0} {1}", playerPosition[0], playerPosition[1]));
                return true;
            }
            else if (lair[newPositio[0], newPositio[1]] == "B")
            {
                PrintBunnyLair(lair);
                Console.WriteLine(string.Format("dead: {0} {1}", newPositio[0], newPositio[1]));
                return true;
            }
            else
            {
                lair[newPositio[0], newPositio[1]] = "P";
                lair[playerPosition[0], playerPosition[1]] = ".";
                playerPosition = newPositio;
                return false;
            }
        }

        private static bool MultiplyBunnys(string[,] bunnyLair)
        {
            
            for (int i = 0; i < bunnyLair.GetLength(0); i++)
            {
                
                for (int j = 0; j < bunnyLair.GetLength(1); j++)
                {
                    if (bunnyLair[i, j] == "B")
                    {
                        if (i + 1 < bunnyLair.GetLength(0))
                        {
                            if (bunnyLair[i + 1, j] == "P")
                            {
                                PrintBunnyLair(bunnyLair);
                                Console.WriteLine(string.Format("dead: {0} {1}", i + 1, j));
                                return true;
                            }
                            else
                            {
                                bunnyLair[i + 1, j] = "B";
                            }
                        }

                        if (i - 1 > -1)
                        {
                            if (bunnyLair[i - 1, j] == "P")
                            {
                                PrintBunnyLair(bunnyLair);
                                Console.WriteLine(string.Format("dead: {0} {1}", i - 1, j));
                                return true;
                            }
                            else
                            {
                                bunnyLair[i - 1, j] = "B";
                            }
                        }
                        if (j - 1 > -1)
                        {
                            if (bunnyLair[i , j-1] == "P")
                            {
                                PrintBunnyLair(bunnyLair);
                                Console.WriteLine(string.Format("dead: {0} {1}", i , j-1));
                                return true;
                            }
                            else
                            {
                                bunnyLair[i, j-1] = "B";
                            }
                        }
                        if (j + 1 >bunnyLair.GetLength(1))
                        {
                            if (bunnyLair[i, j + 1] == "P")
                            {
                                PrintBunnyLair(bunnyLair);
                                Console.WriteLine(string.Format("dead: {0} {1}", i, j + 1));
                                return true;
                            }
                            else
                            {
                                bunnyLair[i, j + 1] = "B";
                            }
                        }
                    }
                }
            }
            return false;
        }

        private static void PrintBunnyLair(string[,] bunnyLair)
        {
            for (int i = 0; i < bunnyLair.GetLength(0); i++)
            {
               
                for (int j = 0; j < bunnyLair.GetLength(1); j++)
                {
                    Console.Write(bunnyLair[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
