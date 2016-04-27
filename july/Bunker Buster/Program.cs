using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunker_Buster
{
    class Program
    {
        static bool IsCellValid(int row, int col, int[,] matrix)
        {
            bool ressult = row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1);
            return ressult;
        }

        static void Main(string[] args)
        {

            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            int[,] field = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[] line = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    field[i, j] = line[j];
                }
            }
            while (true)
            {
                string bomb = Console.ReadLine();
                if (bomb == "cease fire!")
                {
                    break;
                }
                string[] bombcmd = bomb.Trim().Split();
                int bombRow = int.Parse(bombcmd[0]);
                int bombCol = int.Parse(bombcmd[1]);
                double power = (int)(bombcmd[2].ToCharArray().First());
                int halfPower = (int)Math.Ceiling(power / 2);
                field[bombRow, bombCol] -= (int)power;
                for (int i = bombRow - 1; i <= bombRow + 1; i++)
                {
                    for (int j = bombCol - 1; j <= bombCol + 1; j++)
                    {
                        if (!(i == bombRow && j == bombCol)&& IsCellValid(i, j, field))
                        {
                            field[i, j] -= halfPower;
                        }
                    }
                }
            }
            double destroyedCount = 0;
            for (int i = 0; i <rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (field[i,j]<=0)
                    {
                        destroyedCount++;
                    }
                }
            }
            Console.WriteLine("Destroyed bunkers: "+destroyedCount);
            Console.WriteLine(string.Format("Damage done: {0:F1} %",(destroyedCount/(rows*cols))*100));
        }
    }
}
