

namespace Problem_1.Series_of_Letters
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter string:");
            StringBuilder inputString = new StringBuilder();
            inputString.AppendLine(Console.ReadLine());
            string pattern = @"([a-zA-Z0-9])\1{1,}";
            Regex regex = new Regex(pattern);

            var matches = regex.Matches(inputString.ToString());

            foreach (Match match in matches)
            {
                string replace = match.Value.First().ToString();
                inputString.Replace(match.Value, replace);
            }

            Console.WriteLine(inputString);
        }
    }
}
