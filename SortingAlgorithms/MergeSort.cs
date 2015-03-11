using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Debug.WriteLine("Starting Merge sort.");
            if(list.Count > 1)
                Mergesort(list, 0, list.Count-1);
            Debug.WriteLine("\nEnd of Merge sort. \n");
            return list;
        }

        private IList<T> Mergesort(IList<T> list, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left)/2;
                Mergesort(list, left,middle);
                Mergesort(list, middle + 1, right);
                Merge(list, left, middle, right);
                Debug.Write("\n Next Pass:- ");
                DebugDiaglostics<T>.Print(list);
            }
            return list;
        }

        private void Merge(IList<T> list, int left, int middle, int right)
        {
            int i, j, k;
            int n1 = middle - left + 1;
            int n2 = right - middle;

            /* create temp arrays */
            List<T> leftList = new List<T>(n1+1), rightList = new List<T>(n2+1);

            /* Copy data to temp arrays L[] and R[] */
            for (i = 0; i < n1; i++)
                leftList.Insert(i, list[left + i]);
            for (j = 0; j < n2; j++)
                rightList.Insert(j, list[middle + 1 + j]);

            /* Merge the temp arrays back into arr[l..r]*/
            i = 0;
            j = 0;
            k = left;
            while (i < n1 && j < n2)
            {
                if (leftList[i] .CompareTo(rightList[j]) < 0)
                {
                    list[k]= leftList[i];
                    i++;
                }
                else
                {
                    list[k]=  rightList[j];
                    j++;
                }
                k++;
            }

            /* Copy the remaining elements of L[], if there are any */
            while (i < n1)
            {
                list[k] = leftList[i];
                i++;
                k++;
            }

            /* Copy the remaining elements of R[], if there are any */
            while (j < n2)
            {
                list[k] = rightList[j];
                j++;
                k++;
            }

        }
    }
}
