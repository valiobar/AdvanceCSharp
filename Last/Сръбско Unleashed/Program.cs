namespace Сръбко_Unleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text.RegularExpressions;

    using static System.Decimal;

    class Program
    {
        static void Main()
        {
            Regex reg = new Regex(@"(.+)\s@(\w+\s?\w+)\s(\d+)\s(\d+)");
         List<KeyValuePair<string, Dictionary<string, decimal>>> venuData =
                new List<KeyValuePair<string, Dictionary<string, decimal>>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="End")
                {
                    break;
                }
                if (reg.IsMatch(input))
                {
                    string singer = reg.Match(input).Groups[1].Value;
                    string venue = reg.Match(input).Groups[2].Value;
                    decimal ticketPrice =decimal.Parse(reg.Match(input).Groups[3].Value);
                    int tickets= int.Parse(reg.Match(input).Groups[4].Value);
                    decimal income = ticketPrice * tickets;
                    Dictionary<string,decimal>singerIncome=new Dictionary<string, decimal>() { {singer,income} };
                    if (venuData.Any(v => v.Key == venue && v.Value.ContainsKey(singer)))
                    {
                        venuData.First(v => v.Key == venue && v.Value.ContainsKey(singer)).Value[singer] += income;
                    }
                    else
                    {
                        venuData.Add(new KeyValuePair<string, Dictionary<string, decimal>>(venue, singerIncome));
                    }
                    
                }
            }
         Dictionary<string,List<string>>outpot=new Dictionary<string, List<string>>();
            foreach (var v in venuData)
            {
                if (outpot.ContainsKey(v.Key))
                {
                    outpot[v.Key].Add(string.Format("#  {0} -> {1}",v.Value.));
                }
            }
        }
    }
}
