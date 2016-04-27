using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Sequences_of_Equal_Strings
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter strings separated by a space:");
            string[] input = Console.ReadLine().Split(' ');
            List<string> equals = new List<string>();
            equals.Add(input[0]);
            if (input.Length == 1)
            {
                Console.WriteLine(string.Join(" ", equals));
            }
            for (int i = 1; i < input.Length; i++)
            {
                if (equals.Last() == input[i])
                {
                    equals.Add(input[i]);
                }
                else
                {
                    Console.WriteLine(string.Join(" ", equals));
                    equals.Clear();
                    equals.Add(input[i]);
                }
                if (i == input.Length - 1)
                {
                    Console.WriteLine(string.Join(" ", equals));
                }
            }
        }
    }
}
