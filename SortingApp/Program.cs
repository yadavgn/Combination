using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms;

namespace SortingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3, 4, 5, 6, 7, 5, 44, 52, 33, 23};

            var t = AlgoFactory<int>.GetSortingAlgo(AlgoType.Selection);
            t.Sort(array);

            t = AlgoFactory<int>.GetSortingAlgo(AlgoType.Bubble);
            t.Sort(array);

        }
    }
}
