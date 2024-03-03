namespace Algorithms.Sorting
{
    // https://en.wikipedia.org/wiki/Bubble_sort
    public static class BubbleSortExtensions
    {
        public static IList<T> BubbleSort<T>(this IList<T> list) where T : IComparable<T>
        {
            // Create a copy of the origional list.
            var sortedList = new List<T>(list);
            
            // This flag will keep track of whether any elements were swapped in the last pass.
            // If no elements are swapped, the list is considered sorted, and the loop can terminate.
            bool swapped;
            do
            {
                // Initially assume no swaps will be made during this pass.
                swapped = false;
                
                // Iterate over the list, stopping one short of the last element to avoid index out of range errors.
                for (int i = 0; i < sortedList.Count - 1; i++)
                {
                    // Use CompareTo to compare adjacent elements. If the current element is greater than the next, they are out of order, and a swap is needed.
                    if (sortedList[i].CompareTo(sortedList[i + 1]) > 0)
                    {
                        // Uses Tuple Swapping to swap the values
                        (sortedList[i + 1], sortedList[i]) = (sortedList[i], sortedList[i + 1]);

                        // Since a swap was made, set the flag to true to indicate another pass is needed.
                        swapped = true;
                    }
                }
            // Continue looping until a pass is made with no swaps, indicating the list is sorted.
            } while (swapped);
            
            return sortedList;
        }
    }
}
