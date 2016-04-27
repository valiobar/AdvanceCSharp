using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rage_Quit
{
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<char>symbols=new List<char>();
            string input = Console.ReadLine().ToUpper();
            string pattern = @"(\D+(?=[0-9]))(\d+)";
            Regex reg=new Regex(pattern);
            StringBuilder output=new StringBuilder();
            foreach (Match match in reg.Matches(input))
            {
                symbols.AddRange(match.Groups[1].Value.ToCharArray());
                for (int i = 0; i < int.Parse(match.Groups[2].Value); i++)
                {
                    output.Append(match.Groups[1].Value);
                }
            }
            count=symbols.Distinct().Count();
            Console.WriteLine("Unique symbols used: " + count);
            Console.WriteLine(output);
        }
    }
}
