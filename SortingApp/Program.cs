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
            int[] array = {71, 52, 44, 33,34,23, 14,  6,5,  4 };

            var t = AlgoFactory<int>.GetSortingAlgo(AlgoType.Selection);
            //t.Sort(array);

            //t = AlgoFactory<int>.GetSortingAlgo(AlgoType.Bubble);
            //t.Sort(array);

            t = AlgoFactory<int>.GetSortingAlgo(AlgoType.Merge);
            t.Sort(array);
        }
    }
}
