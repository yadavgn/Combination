using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class SelectionSort<T> :ISortingAlgo<T>
        where T: IComparable
    {

        public IList<T> Sort(IList<T> list)
        {
            Debug.WriteLine("Starting Selection sort.");
            for (int currIndex = 0; currIndex < list.Count; currIndex++)
            {
                int smallIndex = currIndex;
                for (int index = currIndex+1; index < list.Count; index++)
                {
                    if (list[smallIndex].CompareTo(list[index]) > 0)
                        smallIndex = index;
                }

                Utility<T>.Swape(list, currIndex, smallIndex);

                System.Diagnostics.Debug.Write("\n Pass { "+currIndex+" }");
                DebugDiaglostics<T>.Print(list);
            }
            Debug.WriteLine("\nEnd of Selection sort. \n");

            return list;
        }
    }
}
