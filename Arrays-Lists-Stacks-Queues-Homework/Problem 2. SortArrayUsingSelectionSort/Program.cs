namespace Problem_2.SortArrayUsingSelectionSort
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by a space:");
            int[] nonSortedArrey = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < nonSortedArrey.Length - 1; i++)
            {
                for (int j = i + 1; j < nonSortedArrey.Length; j++)
                {
                    int temp = nonSortedArrey[i];

                    if (nonSortedArrey[j] < nonSortedArrey[i])
                    {
                        nonSortedArrey[i] = nonSortedArrey[j];
                        nonSortedArrey[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", nonSortedArrey));
        }
    }
}
