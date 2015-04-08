

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

class DecentNumber
{
    static void Main2(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string input = Console.ReadLine();
        int N = Int32.Parse(input);

        var nums = new int[N];

        for(int i = 0; i < N; i++)
        {
            input = Console.ReadLine();
            if(string.IsNullOrEmpty(input)) continue;

            nums[i] = Int32.Parse(input);
            Console.WriteLine(GetDecentNumber(nums[i]));

        }
    }

    private static string GetDecentNumber(int Digits)
    {
        if (Digits < 3) return "-1"; // not possible.

        return CheckCount(Digits, 0);
    }

    private static string CheckCount(int fives, int threes)
    {
        if (threes%5 == 0 && fives%3 == 0) // solution found.
        {
            //checked 
            if (((threes*3) + (fives*5))%3 == 0)
            {
                return new string('5', fives) + new string('3', threes);
            }
            else
            {
                return new string('5', fives-1) + new string('3',threes)+'5';
            }
        }
        else if (fives - 5 >= 0)
        {
            return CheckCount(fives - 5, threes + 5);
        }

        return "-1";
    }
}


