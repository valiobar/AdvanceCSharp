using System;
using System.Collections.Generic;
using System.Linq;


namespace Problem_3.Categorize_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number separated by a space:");
            float[] inputArrey = Console.ReadLine().Split(' ').Select(float.Parse).ToArray();
            List<float> roundNumbers = new List<float>();
            List<float> nonRoundNumbers = new List<float>();
            foreach (var num in inputArrey)
            {
                if (num % 1 ==0)
                {
                    roundNumbers.Add(num);
                }

                else
                {
                    nonRoundNumbers.Add(num);
                }
            }
            Console.WriteLine(
                string.Format(
                    "[{0}]->min:{1}, max:{2}, sum:{3}, avg:{4:F2}",
                    string.Join(" ", nonRoundNumbers),
                    nonRoundNumbers.Min(),
                    nonRoundNumbers.Max(),
                    nonRoundNumbers.Sum(),
                    nonRoundNumbers.Average()));
        }
    }
}
