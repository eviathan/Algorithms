using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    // https://en.wikipedia.org/wiki/Bubble_sort
    public static class BubbleSortExtensions
    {
        public static IList<T> BubbleSort<T>(this IList<T> list) where T : IComparable<T>
        {
            var sortedList = new List<T>(list);
            
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < sortedList.Count - 1; i++)
                {
                    if (sortedList[i].CompareTo(sortedList[i + 1]) > 0)
                    {
                        // Swap if they are in the wrong order
                        T temp = sortedList[i];
                        sortedList[i] = sortedList[i + 1];
                        sortedList[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
            
            return sortedList;
        }
    }
}