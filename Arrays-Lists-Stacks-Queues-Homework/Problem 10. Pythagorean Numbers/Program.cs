using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Pythagorean_Numbers
{
    

    class Program
    {
        private static int[] inputNumbers;
        static void Main()
        {
            int[] combination=new int[3];
            inputHandler();
            GenerateCombinations(0,0,inputNumbers,combination);
        }

        private static void inputHandler()
        {
            int numersCount = int.Parse(Console.ReadLine());
            inputNumbers=new int[numersCount];
            for (int i = 0; i < numersCount; i++)
            {
                inputNumbers[i] = int.Parse(Console.ReadLine());
            }
        }

        private static bool CheckForPythagoreanNumbers(int[] numbers )
        {
            bool arePitagoreanNumbers = false;
            arePitagoreanNumbers = numbers[0] * numbers[0] +
                numbers[1] * numbers[1]
                == numbers[2] * numbers[2];
            return arePitagoreanNumbers;
        }

        private static void GenerateCombinations(int index,int start, int[] inputNumbers,int[] combination)
        {
            if (index >= combination.Length )
            {
                if (CheckForPythagoreanNumbers(combination))
                {
                    Console.WriteLine(string.Format("{0}*{0} + {1}*{1} = {2}*{2}", combination[0], combination[1], combination[2]));
                }
               
            }
            else
            {
                for (int i = 0; i < inputNumbers.Length; i++)
                {
                    combination[index] = inputNumbers[i];
                    GenerateCombinations(index+1,start,inputNumbers,combination);
                }
            }
            
        }
    }
}
