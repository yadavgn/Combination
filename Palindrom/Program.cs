using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            const string input = "AABDDDBACCA";
            int[] selected = new int[input.Length];
            int cnt = CandidateCode.PalindromeLengthPuzzle(input, 0, input.Length - 1, 1);
            Console.WriteLine(cnt);
        }
    }
}
