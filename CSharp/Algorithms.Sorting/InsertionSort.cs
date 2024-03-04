using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    // https://en.wikipedia.org/wiki/Insertion_sort
    public static class InsertionSortExtensions
    {
        public static IList<T> InsertionSort<T>(this IList<T> list) where T : IComparable<T>
        {
            // Create a copy of the original list to maintain immutability of the input.
            var sortedList = new List<T>(list);

            // Start from the second element as the first element is already considered sorted.
            for (int i = 1; i < sortedList.Count; i++)
            {
                // Store the current value because it might shift later.
                T currentValue = sortedList[i];

                // The index of the previous element.
                int previousIndex = i - 1;

                // Loop backwards through the sorted portion of the list and find the right position for 'currentValue'.
                // Elements that are greater than 'currentValue' are moved one position up to make space for 'currentValue'.
                while (previousIndex >= 0 && sortedList[previousIndex].CompareTo(currentValue) > 0)
                {
                    sortedList[previousIndex + 1] = sortedList[previousIndex];
                    previousIndex--;
                }

                // Place 'currentValue' in its correct position.
                sortedList[previousIndex + 1] = currentValue;
            }

            return sortedList;
        }

    }
}