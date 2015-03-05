using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Utility<T> where T : IComparable
    {
        internal static void Swape(IList<T> list, int pass, int smallIndex)
        {
            var temp = list[pass];
            list[pass] = list[smallIndex];
            list[smallIndex] = temp;
        }
    }
}