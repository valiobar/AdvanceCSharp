using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_5.Longest_Increasing_Sequence
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by a space:");
            int[] inputArrey = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<List<int>> list = new List<List<int>>();
            List<int> nestedList = new List<int>();
            int listIndex = 0;
            for (int i = 0; i < inputArrey.Length; i++)
            {
                if (i == inputArrey.Length - 1)
                {
                    list.Add(nestedList);
                }

                if (nestedList.Count == 0 || inputArrey[i] > nestedList.Last())
                {
                    nestedList.Add(inputArrey[i]);
                }
                else
                {
                    list.Add(nestedList);
                    nestedList = new List<int>();
                    nestedList.Add(inputArrey[i]);
                    
                }
            }
            foreach (var item in list)
            {
                Console.WriteLine(string.Join(" ", item));
            }

            var logest = list.OrderByDescending(x => x.Count).First();
            Console.WriteLine(string.Format("Longest: {0}", 
                string.Join(" ", logest)));
        }
    }
}
