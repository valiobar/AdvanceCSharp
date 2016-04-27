using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect_Resources
{
    using System.Linq.Expressions;

    class Program
    {
        static void Main()
        {
            string[] validRes = new[] { "stone", "gold", "wood", "food" };
            string[] resf = Console.ReadLine().Split();
            List<int> resQuality=new List<int>();
            foreach (var res in resf)
            {
                string[] op = res.Split('_');
                if (validRes.Contains(op[0]))
                {
                    if (op.Length == 1)
                    {
                        resQuality.Add(1);
                    }
                    else
                    {
                        resQuality.Add(int.Parse(op[1]));
                    }
                }
                else
                {
                    resQuality.Add(0);
                   
                }
            }
            int lines = int.Parse(Console.ReadLine());
            List<long> sums=new List<long>();
            for (int i = 0; i < lines; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int[] exList = resQuality.ToArray();
                sums.Add(Execute(input[0], input[1], exList));
            }
            Console.WriteLine(sums.Max());
        }

        private static long Execute(int startIndex, int step,int[] resurse)
        {
            long sum = 0;
            
            while (true)
            {

                int currentIndex = startIndex;
                if (resurse[currentIndex]<0)
                {
                    break;
                    
                }
                sum += (long)resurse[currentIndex];
                if (resurse[currentIndex]!=0)
                {
                    resurse[currentIndex] = -1;
                }
                
                startIndex = (startIndex + step)%resurse.Length;
            }
            return sum;

        }
    }
}
