using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecentNumberApp
{
    internal class MinMax
    {

        private static void Main1(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string input = Console.ReadLine();
            int N = Int32.Parse(input);

            input = Console.ReadLine();
            int K = Int32.Parse(input);

            var nums = new int[N];

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue;
                nums[i] = Int32.Parse(input);
            }

            Console.WriteLine(GetUnfairness(nums, K));

        }

        private static int GetUnfairness(int[] nums, int K)
        {
            List<int> list = new List<int>(nums);
            list.Sort();

            List<int> diff = new List<int>(nums.Length - 1);

            for (int index = 0; index < nums.Length - K + 1; index++)
            {
                diff.Add(list[index + K - 1] - list[index]);
            }

            return diff.Min();
        }



    }
}
