namespace Problem_7.Sorted_Subset_Sums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private static int sum;

        private static int[] numbers;

        private static List<List<int>> allSubset = new List<List<int>>();

        private static int matchedSubsets=0;

        static void Main()
        {
            Console.Write("Enter sum that you want to check for: ");
            sum = int.Parse(Console.ReadLine());
            Console.Write("Enter numbers separate by space: ");
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> subsetSum = new List<int>();
            GetSubsets(0, subsetSum);
            PrintCombinations(allSubset);
        }

        private static void GetSubsets(int index, List<int> subset)
        {
            if (subset.Sum() == sum)
            {
                AddToAllCombination(allSubset, subset);
                matchedSubsets++;
            }

            for (int i = index; i < numbers.Length; i++)
            {
                subset.Add(numbers[i]);
                GetSubsets(i + 1, subset);
                subset.RemoveAt(subset.Count - 1);
            }
        }

        private static void AddToAllCombination(List<List<int>> allSubset, List<int> subsetSum)
        {
            List<int> listToAdd = new List<int>();

            foreach (var num in subsetSum)
            {
                listToAdd.Add(num);
            }

            allSubset.Add(listToAdd);
        }

        private static void PrintCombinations(List<List<int>> allSubset)
        {
            if (matchedSubsets == 0)
            {
                Console.WriteLine("No matching subsets.");
            }
            else
            {
                foreach (var combination in allSubset.OrderBy(subse => subse.Count).ThenBy(subset => subset.First()))
                {
                    Console.WriteLine(string.Join(" + ", combination) + " = " + sum);
                }
            }
        }

    }
}
