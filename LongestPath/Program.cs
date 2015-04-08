using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPath
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = {"1#2", "2#3", "1#11","3#11","4#11"};
            int cnt = CandidateCode.maxno_city(input);

            string[] input1 = { "1#2", "2#3", "1#11", "3#11", "4#11","4#5", "5#6", }; // 7
            cnt = CandidateCode.maxno_city(input1);

            string[] input2 = { "1#2", "2#3", "1#11", "3#11", "4#11", "4#5", "5#6", "5#7" }; // 7
            cnt = CandidateCode.maxno_city(input2);


            string[] input3 = { "1#2", "2#3", "1#11", "3#11", "4#11", "4#5", "5#6", "5#7","6#7", "4#12","8#12","9#12","8#10", "9#10","8#9" }; // 7
            cnt = CandidateCode.maxno_city(input3);
            Console.WriteLine(cnt);
        }
    }
}
