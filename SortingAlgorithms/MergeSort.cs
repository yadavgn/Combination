using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class MergeSort<T> : ISortingAlgo<T>
        where T: IComparable
    {
        public IList<T> Sort(IList<T> list)
        {
            List<T> _list = new List<T>(list.Count);
            for (int pass = 0; pass < list.Count; pass++)
            {
                for (int index = 0; index < list.Count-pass; index++)
                {
                    //if()
                }
            }
            return list;
        }
    }
}
