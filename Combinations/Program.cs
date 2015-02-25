using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Program
    {
        private static int count;
        static void Main(string[] args)
        {
            count = 1;
            printCombinations("AB", 0,"");

            Console.ReadLine();
        }

        static void printCombinations(String input, int index, String combination)
        {
            if (combination.Length == input.Length)
            {
                Console.WriteLine("{0} , {1}", count++, combination);
                return;
            }
            foreach (var _char in input)
            {
                printCombinations(input, index + 1, combination + _char);
            }
        }
    }
}
