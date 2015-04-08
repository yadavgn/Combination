using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecentNumberApp
{
    class MarbleCut
    {
        public static void GetMarbleCut(String[] args)
        {
            int _a_count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < _a_count; i++)
            {
                int[] _a = new int[2];
                int _a_item;
                String move = Console.ReadLine();
                String[] move_split = move.Split(' ');
                for (int _a_i = 0; _a_i < 2; _a_i++)
                {
                    _a_item = Convert.ToInt32(move_split[_a_i]);
                    _a[_a_i] = _a_item;
                }

                int _a_area = _a[0]*_a[1];
                int remaining = _a_area%3;
                Console.WriteLine(remaining == 0 ? "YES" : "NO " + remaining);

            }
        }
    }



}
