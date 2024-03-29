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

            // Marks the end of the unsorted section of the list. With each iteration, this boundary is 
            // reduced by 1 as the largest elements are bubbled to their sorted position at the end of the list,
            // thereby reducing the number of comparisons in subsequent passes.
            var unsortedBoundary = sortedList.Count;

            do
            {
                // Initially assume no swaps will be made during this pass.
                swapped = false;

                // Iterate over the list, stopping one short of the last element to avoid index out of range errors.
                for (var i = 0; i < unsortedBoundary - 1; i++)
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

                // After each pass, reduce the range of the inner loop, since the last element is already sorted.
                unsortedBoundary--;
            }
            // Continue looping until a pass is made with no swaps, indicating the list is sorted. 
            while (swapped);
            
            return sortedList;
        }
    }
}
