using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDecentNumber
{
    /// <summary>
    /// This class will find the decent number based on the input digit given as input.
    /// </summary>
    public class NumberFinder
    {
        private readonly int _digit1;
        private readonly int _digit2;

        public NumberFinder(int digit1, int digit2)
        {
            this._digit1 = digit1;
            this._digit2 = digit2;
        }

        private const String NoSolution = "-1";

        public String GetDecentNumber(int digitCount)
        {
            int minDigit = Math.Min(_digit1, _digit2);

            if (digitCount < minDigit)
            {
                return NoSolution; // no number possible for the given input.
            }
            int maxDigit = Math.Max(_digit1, _digit2);


            return NoSolution;
        }
    }
}
