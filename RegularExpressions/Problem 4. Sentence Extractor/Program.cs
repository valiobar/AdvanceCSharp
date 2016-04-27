
namespace Problem_4.Sentence_Extractor
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string pattern = "[^.!?;]*( is )[^.!?;]*";
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
