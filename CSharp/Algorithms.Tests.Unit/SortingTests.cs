
using Algorithms.Sorting;

namespace Algorithms.Tests.Unit;

public class SortingTests
{
    [Fact]
    public void BubbleSort()
    {
        // Arrange
        List<int> list = [ 5, 3, 8, 1, 2 ];
        List<int> expected = [ 1, 2, 3, 5, 8 ];

        // Act
        var sortedList = list.BubbleSort();

        // Assert
        Assert.Equal(expected, sortedList);
    }

    [Fact]
    public void InsertionSort()
    {
        // Arrange
        List<int> list = [ 5, 3, 8, 1, 2 ];
        List<int> expected = [ 1, 2, 3, 5, 8 ];

        // Act
        var sortedList = list.InsertionSort();

        // Assert
        Assert.Equal(expected, sortedList);
    }
}