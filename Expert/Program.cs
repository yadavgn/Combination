using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = CandidateCode.sequences("1,2,3,4,5");
            Console.WriteLine(output);
            
            
            output = CandidateCode.sequences("1,5,9,2,3,5,6");
            Console.WriteLine(output);

        }
    }
}
