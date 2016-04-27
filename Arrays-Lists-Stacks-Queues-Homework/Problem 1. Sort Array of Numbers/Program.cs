namespace Problem_1.Sort_Array_of_Numbers
{
    using System;
    using System.Linq;

    class SortArrayOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by a space:");
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Select(int.Parse).ToArray().OrderBy(x => x)));
        }
    }
}

