using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shmoogle_Counter
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> ints=new List<string>();
            List<string> doubles = new List<string>();

            StringBuilder sourceCode=new StringBuilder();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine== "//END_OF_CODE")
                {
                    break;
                }
                sourceCode.AppendLine(inputLine);
            }
            string pattern = @"((?<=int\s)\w*(?=\s))|((?<=double\s)\w*(?=\s))";
            Regex regex=new Regex(pattern);
            foreach (Match match in regex.GetGroupNumbers())
            {
               doubles.Add(match.Groups[1].Value);
                ints.Add(match.Groups[2].Value);
            }
        }
    }
}
