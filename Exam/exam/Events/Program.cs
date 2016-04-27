using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string patter = "#([a-zA-z]+): ?@ ?([a-zA-z]+) ?(([0-1][0-9]:|2[0-3]:)[0-5][0-9])";
            Regex matchInput = new Regex(patter);
            Dictionary<string, SortedDictionary<string, List<string>>> data =
                new Dictionary<string, SortedDictionary<string, List<string>>>();
            int eventsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < eventsCount; i++)
            {
                string input = Console.ReadLine();
                if (matchInput.IsMatch(input))
                {
                    string city = matchInput.Match(input).Groups[2].Value;
                    string name = matchInput.Match(input).Groups[1].Value;
                    string hours = matchInput.Match(input).Groups[3].Value;
                    if (!data.ContainsKey(city))
                    {
                        data[city] = new SortedDictionary<string, List<string>>();
                    }
                    if (!data[city].ContainsKey(name))
                    {
                        data[city][name] = new List<string>();
                    }
                    data[city][name].Add(hours);
                }
            }
            string[] outputCitys = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var city in outputCitys.OrderBy(c => c))
            {
                if (data.ContainsKey(city))
                {
                    Console.WriteLine(city+":");
                    int num = 1;
                    foreach (var p in data[city])
                    {
                        
                        Console.WriteLine(string.Format("{0}. {1} -> {2}",num, p.Key,string.Join(", ",p.Value.OrderBy(h=>h))));
                        num++;
                    }
                }
            }
        }
    }
}
