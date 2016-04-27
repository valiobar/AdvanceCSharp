

namespace Problem_9.Stuck_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static string[] inputNumbers;

        private static List<string[]> allCombinations=new List<string[]>();

        private static int StuckNumbersCount = 0;
        static void Main(string[] args)
        {
            
            inputHandler();
            string[] comb = new string[inputNumbers.Length];
            FindAllPairs(comb,0,0);
            CheckForStuckNumbers();

        }

        private static void inputHandler()
        {
            int numersCount = int.Parse(Console.ReadLine());
            inputNumbers = Console.ReadLine().Split(' ').ToArray();
            
        }

        private static void FindAllPairs(string[] pair,int startIndex=0, int index = 0)
        {
            
            if (index==2&&pair[0]!=pair[1])
            {
                allCombinations.Add(new string[] {pair[0],pair[1]});
            }
            for (int i = startIndex; i < inputNumbers.Length; i++)
            {
                pair[index] = inputNumbers[i];
                FindAllPairs(pair,startIndex+1,index+1);

            }
        }

        private static void CheckForStuckNumbers()
        {
            for (int i = 0; i <allCombinations.Count; i++)
            {
                string firstString = string.Concat(allCombinations[i]);
                for (int j = 0; j < allCombinations.Count; j++)
                {
                    string secondString = string.Concat(allCombinations[j]);
                    if (firstString==secondString&&i!=j)
                    {
                        StuckNumbersCount++;
                        PrintStuckNumbers(allCombinations[i], allCombinations[j]);
                    }
                }

            }

        }

        private static void PrintStuckNumbers(string[] firstNumber, string[] secondNumber)
        {
            Console.WriteLine(string.Format("{0}|{1}=={2}|{3}",firstNumber[0],firstNumber[1],secondNumber[0],secondNumber[1]));
        }

    }
}
