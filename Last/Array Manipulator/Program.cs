using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Manipulator
{
    using System.Runtime.InteropServices;

    class Program
    {
       
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="end")
                {
                    Console.WriteLine("["+string.Join(", ",inputNumbers)+"]");
                    break;
                }
                Execut(input,inputNumbers);
            }
        }

        private static void Execut(string input,int[]inputNumbers)
        {
            string[] Command = input.Split();

            switch (Command[0])
            {
                case "first":
                    First(inputNumbers,int.Parse(Command[1]),Command[2]);
                    break;
                case "last":
                    Last(inputNumbers, int.Parse(Command[1]), Command[2]);
                    break;
                case "exchange":
                    Exchange(inputNumbers, int.Parse(Command[1]));
                    break;
                case "max":
                    Max(inputNumbers, Command[1]);
                    break;
                case "min":
                    Min(inputNumbers, Command[1]);
                    break;
            }
        }
        private static void Exchange(int[] input, int index)
        {
            if (index < 0 || index > input.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            int[] firstSubArrey = new int[index + 1];
            int[] secondSubArrey = new int[input.Length - (index + 1)];
            for (int i = 0; i < firstSubArrey.Length; i++)
            {
                firstSubArrey[i] = input[i];
            }

            for (int i = 0; i < secondSubArrey.Length; i++)
            {
                secondSubArrey[i] = input[index + 1 + i];
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - (index + 1))
                {
                    input[i] = secondSubArrey[i];
                }
                else
                {
                    input[i] = firstSubArrey[i - secondSubArrey.Length];
                }
            }
        }

        private static void Max(int[] input, string typeOfNumber)
        {
            int maxEven = 0;
            int maxOdd = 0;
            int countEven = 0;
            int countOdd = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    if (countEven == 0)
                    {
                        maxEven = i;
                       countEven++;
                    }
                    else
                    {
                        if (input[i] >=input[maxEven])
                        {
                            maxEven =i;
                        }
                    }
                }
                else
                {
                    if (countOdd == 0)
                    {
                        maxOdd = i;
                        countOdd++;
                    }
                    else
                    {
                        if (input[i] >= input[maxOdd])
                        {
                            maxOdd =i;
                        }
                    }
                }
            }
            if (typeOfNumber=="even")
            {
                if (countEven == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(maxEven);
                }
                
            }
            else
            {
                if (countOdd == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(maxOdd);
                }
              
            }
        }
        private static void Min (int[] input, string typeOfNumber)
        {
            int minEven = 0;
            int minOdd = 0;
            int countEven = 0;
            int countOdd = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    if (countEven == 0)
                    {
                        minEven = i;
                        countEven++;
                    }
                    else
                    {
                        if (input[i] <= input[minEven])
                        {
                            minEven = i;
                        }
                    }
                }
                else
                {
                    if (countOdd == 0)
                    {
                        minOdd = i;
                        countOdd++;
                    }
                    else
                    {
                        if (input[i] <= input[minOdd])
                        {
                            minOdd = i;
                        }
                    }
                }
            }
            if (typeOfNumber == "even")
            {
                if (countEven==0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(minEven);
                }
            }

            else
            {
                if (countOdd == 0)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(minOdd);
                }
                
            }
        }

        private static void First(int[] input, int count, string numberType)
        {
            if (count < 0 || count > input.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            List<int> Even = new List<int>();
            List<int> Odd = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    Even.Add(input[i]);
                }
                else
                {
                    Odd.Add(input[i]);
                }

            }
            List<int>result = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (numberType == "even")
                {
                    if (i < Even.Count)
                    {
                        result.Add(Even[i]);
                    }
                    
                }
                else
                {
                    if (i<Odd.Count)
                    {
                        result.Add(Odd[i]);
                    }
                   
                }
            }
            if (result.Count==0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                StringBuilder print = new StringBuilder();
                print.Append("[");
                print.Append(string.Join(", ", result));
                print.Append("]");
                Console.WriteLine(print);
            }
            
        }

        private static void Last(int[] input, int count, string numberType)
        {
            if (count < 0 || count > input.Length )
            {
                Console.WriteLine("Invalid count");
                return;
            }
            List<int> Even = new List<int>();
            List<int> Odd = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    Even.Add(input[i]);
                }
                else
                {
                    Odd.Add(input[i]);
                }

            }
            List<int> result = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (numberType == "even")
                {
                    if (i < Even.Count)
                    {
                        result.Add(Even[i+(Even.Count-count)]);
                    }

                }
                else
                {
                    if (i < Odd.Count)
                    {
                        result.Add(Odd[i + (Odd.Count - count)]);
                    }

                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                StringBuilder print = new StringBuilder();
                print.Append("[");
                print.Append(string.Join(", ", result));
                print.Append("]");
                Console.WriteLine(print);
            }

        }
    }
}
