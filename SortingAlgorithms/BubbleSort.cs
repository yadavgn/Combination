using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BubbleSort<T> : ISortingAlgo<T>
        where T: IComparable
    {
        public IList<T> Sort(IList<T> list)
        {
            Debug.WriteLine("Starting Bubble sort.");
            List<T> _list = new List<T>(list.Count);
            for (int pass = 0; pass < list.Count; pass++)
            {
                for (int index = pass; index < list.Count; index++)
                {
                    if (list[index].CompareTo(list[pass]) < 0)
                        Utility<T>.Swape(list,pass,index);
                }

                System.Diagnostics.Debug.Write("\n Pass { " + pass + " }");
                DebugDiaglostics<T>.Print(list);
            }
            Debug.WriteLine("\n End of Bubble sort.");
            return list;
        }
    }
}
