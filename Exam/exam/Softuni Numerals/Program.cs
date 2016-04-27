using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Softuni_Numerals
{
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            BigInteger result = 0;
            Dictionary<string, int> symbols = new Dictionary<string, int>();
            symbols["aa"] = 0;
            symbols["aba"] = 1;
            symbols["bcc"] = 2;
            symbols["cc"] = 3;
            symbols["cdc"] = 4;
            string pattern = "aa|aba|bcc|cc|cdc";
            List<int> number5base = new List<int>();
            Regex reg = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches = reg.Matches(input);
            foreach (Match match in matches)
            {
                number5base.Add(symbols[match.Value]);
            }
            for (int i = 0,j=number5base.Count-1; i < number5base.Count;j--, i++)
            {
                result += (BigInteger)number5base[j] * BigInteger.Pow(5,i);
            }
            Console.WriteLine(result);
        }
    }
}
