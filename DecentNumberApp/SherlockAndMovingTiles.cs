using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecentNumberApp
{
    class SherlockAndMovingTiles
    {

        public  static void getTimeforMovintTiles(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */

            try
            {
                string input = Console.ReadLine();

                var inputs = input.Split(' ');

                double L = double.Parse(inputs[0]);
                double S1 = double.Parse(inputs[1]);
                double S2 = double.Parse(inputs[2]);

                input = Console.ReadLine();
                int Q = Int32.Parse(input);

                //var nums = new int[Q];

                for (int i = 0; i < Q; i++)
                {
                    string areaStr = Console.ReadLine();

                    double area = double.Parse(areaStr);

                    Console.WriteLine( getTimeForArea(L, S1, S2, area).ToString("0.0000") );
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static double getTimeForArea(double L, double S1, double S2, double area)
        {
            var relativeSpeed = S2 - S1;
            if (relativeSpeed < 0) relativeSpeed *= -1;
            return (L - Math.Sqrt(area))*(Math.Sqrt(2)/relativeSpeed);
        }

    }
}
