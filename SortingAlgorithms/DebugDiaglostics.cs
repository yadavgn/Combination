using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class DebugDiaglostics<T> where T : IComparable
    {
        internal static void Print(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                System.Diagnostics.Debug.Write(" " + item);
            }
        }
    }
}