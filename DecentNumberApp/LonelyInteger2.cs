﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecentNumberApp
{
    internal class LonelyInteger2
    {

        private static int lonelyinteger(int[] a)
        {
            return a.Aggregate(0, (current, i) => current ^ i);
        }

        public static void GetLonelyInteger(String[] args)
        {
            int res;

            int _a_size = Convert.ToInt32(Console.ReadLine());
            int[] _a = new int[_a_size];
            int _a_item;
            String move = Console.ReadLine();
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                _a[_a_i] = _a_item;
            }

            res = lonelyinteger(_a);
            Console.WriteLine(res);
        }
    }
}
