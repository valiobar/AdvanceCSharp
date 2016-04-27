using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string,long>>report=new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="report")
                {
                    break;
                }
                string[] inputArgs = input.Split('|');
                if (!report.ContainsKey(inputArgs[1]))
                {
                    report[inputArgs[1]]=new Dictionary<string, long>();
                }
                if (!report[inputArgs[1]].ContainsKey(inputArgs[0]))
                {
                    report[inputArgs[1]][inputArgs[0]] = long.Parse(inputArgs[2]);
                }
               
            }
            foreach (var c in report.OrderByDescending(r => r.Value.Values.Sum()))
            {
                Console.WriteLine(string.Format("{0} (total population: {1})",c.Key,c.Value.Values.Sum()));
                foreach (var s in c.Value.OrderByDescending(s=>s.Value))
                {
                    Console.WriteLine(string.Format("=>{0}: {1}",s.Key,s.Value));
                }
            }
              
        }
    }
}
