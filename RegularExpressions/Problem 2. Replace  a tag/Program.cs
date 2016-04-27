
namespace Problem_2.Replace__a_tag
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            StringBuilder input = new StringBuilder();
            
            input.AppendLine(Console.ReadLine());
            string[] replace = new string[] { "[URL", "[/URL]" };
            Regex firstRegex = new Regex(@"(</? a) >?");
            MatchCollection matches = firstRegex.Matches(input.ToString());
            firstRegex.Match()
        }
    }
}
