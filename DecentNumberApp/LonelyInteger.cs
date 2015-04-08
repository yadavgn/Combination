using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecentNumberApp
{
    class LonelyInteger
    {
        public static void GetLonelyInteger()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            
            try
            {
                string input = Console.ReadLine();

                int N = Int32.Parse(input);

                string numStr = Console.ReadLine();
                var inputnums = numStr.Split(' ');
                var numbers = new List<int>(N);

                for (int i = 0; i < inputnums.Length; i++)
                {
                    int num = Int32.Parse(inputnums[i]);
                    numbers.Add(num);
                }

                Console.WriteLine(LonelyInt(numbers));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int LonelyInt(List<int> numbers)
        {
            numbers.Sort();
            int i = 0;
            for (i = 0; i < numbers.Count; i++)
            {
                if(i%2 == 1 )
                    if (numbers[i] != numbers[i - 1])
                    {
                        return numbers[i];
                    }
            }
            return numbers[i-1];
        }




    }
}
