using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo(3, 6);
            Console.WriteLine("Called first time.");
            Foo(3, 6);

            Console.WriteLine("Called second time.");
        }

        static void Foo(int a, int b)
        {
            if(a > b)
                Console.WriteLine(">");
            else if (a < b)
                Console.WriteLine("<");
            else 
                Console.WriteLine("=");
        }
    }
}
