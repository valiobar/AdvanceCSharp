using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Slider
{
    class Program
    {
        private static int currentIndex = 0;
        static void Main(string[] args)
        {
            int[] arrey = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "stop")
                {
                    break;
                }
                string[] commandargs = line.Split();
                int offset = int.Parse(commandargs[0]);
                int operant = int.Parse(commandargs[2]);
                string operation = commandargs[1];
                if (currentIndex + offset<0)
                {
                    currentIndex = arrey.Length + (currentIndex + offset);
                }
               else if (currentIndex + offset > arrey.Length - 1)
               {
                   currentIndex = currentIndex + offset - arrey.Length;
               }
               else
               {
                   currentIndex += offset;
               }
                switch (operation)
                {
                    case "+":
                        arrey[currentIndex] += operant;
                        if (arrey[currentIndex]<0)
                        {
                            arrey[currentIndex] = 0;
                        }
                        break;
                    case "-":
                        arrey[currentIndex] -= operant;
                        if (arrey[currentIndex] < 0)
                        {
                            arrey[currentIndex] = 0;
                        }
                        break;
                    case "&":
                        arrey[currentIndex] &= operant;
                        if (arrey[currentIndex] < 0)
                        {
                            arrey[currentIndex] = 0;
                        }
                        break;
                    case "^":
                        arrey[currentIndex] ^= operant;
                        if (arrey[currentIndex] < 0)
                        {
                            arrey[currentIndex] = 0;
                        }
                        break;
                    case "*":
                        arrey[currentIndex] *= operant;
                        if (arrey[currentIndex] < 0)
                        {
                            arrey[currentIndex] = 0;
                        }
                        break;
                    case "|":
                        arrey[currentIndex] |= operant;
                        if (arrey[currentIndex] < 0)
                        {
                            arrey[currentIndex] = 0;
                        }
                        break;
                    case "/":
                        arrey[currentIndex] /= operant;
                        if (arrey[currentIndex] < 0)
                        {
                            arrey[currentIndex] = 0;
                        }
                        break;

                }
            }
            Console.WriteLine(string.Format("[{0}]",string.Join(", ",arrey)));
        }
    }
}
