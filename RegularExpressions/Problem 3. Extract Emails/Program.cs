

namespace Problem_3.Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
