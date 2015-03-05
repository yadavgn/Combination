using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class AlgoFactory<T>
        where T: IComparable
    {
        public static ISortingAlgo<T> GetSortingAlgo(AlgoType algo)
        {
            switch (algo)
            {
                case AlgoType.Bubble:
                    return new BubbleSort<T>();
                case AlgoType.Insertion:
                    return null;
                case AlgoType.Selection:
                    return new SelectionSort<T>();
                case AlgoType.Merge:
                    return null;
            }
            return null;
        }
    }
}
