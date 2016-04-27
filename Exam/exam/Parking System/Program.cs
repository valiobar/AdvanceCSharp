using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking_System
{
    using System.Threading;

    class Program
    {
        
        static void Main(string[] args)
        {
            int[] startPos = new int[];
            startPos[1] = 0;
            int[] destination = new int[];
            int[] actual = new int[2];
            bool isParked = false;
            int[] parkingSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool[][] parking = new bool[parkingSize[0]][];
            for (int i = 0; i < parkingSize[0]; i++)
            {
                parking[i]=new bool[parkingSize[1]];
                parking[i][0] = true;
            }
            string input = Console.ReadLine();
            while (input!="stop")
            {
              
                int[] park = input.Split().Select(int.Parse).ToArray();
                 startPos[0] = park[0];
                 destination[0] = park[1];
                destination[1] = park[2];
                int offset = 1;
                if (!parking[destination[0]][ destination[1]])
                {
                    actual[0] = destination[0];
                    actual[1] = destination[1];
                    parking[destination[0]][destination[1]] = true;
                    isParked = true;
                    
                }
               else { while (parking[destination[0]].Contains(false))
                {
                    if (destination[1] - offset > 0)
                    {
                        if (!parking[destination[0]][destination[1] - offset])
                        {
                            actual[0] = destination[0];
                            actual[1] = destination[1] - offset;
                            parking[destination[0]][destination[1] - offset] = true;
                            isParked = true;
                            break;
                        }
                    }
                    if (destination[1] + offset < parking[destination[0]].Length)
                    {
                        if (!parking[destination[0]][destination[1] + offset])
                        {
                            actual[0] = destination[0];
                            actual[1] = destination[1] + offset;
                            parking[destination[0]][destination[1]+offset] = true;
                            isParked = true;
                            break;
                        }
                    }
                    offset++;
                }}
                if (!isParked)
                {
                    Console.WriteLine(string.Format("Row {0} full", destination[0]));
                }
                else
                {
                    int count = Math.Abs(destination[0] - startPos[0]) + actual[1] + 1;
                    Console.WriteLine(count);
                }
                input = Console.ReadLine();
                isParked = false;
                
            }
        }
    }
}
