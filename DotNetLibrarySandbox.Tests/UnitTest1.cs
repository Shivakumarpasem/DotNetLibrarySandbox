using DotNetLibrarySandbox.Lib;
using Xunit;

namespace DotNetLibrarySandbox.Tests;

public class UnitTest1
{
    [Fact]
    public void IsPalindrome_VariousInputs_ReturnsExpected()
    {
        // normal cases
        Assert.True(StringHelpers.IsPalindrome("racecar"));
        Assert.True(StringHelpers.IsPalindrome("RaceCar"));
        Assert.False(StringHelpers.IsPalindrome("hello"));
        Assert.False(StringHelpers.IsPalindrome("ab"));

        // edge cases: empty and null
        Assert.False(StringHelpers.IsPalindrome((string?)null));
        Assert.False(StringHelpers.IsPalindrome(string.Empty));
    }

    [Fact]
    public void Reverse_VariousInputs_ReturnsExpected()
    {
        // normal cases
        Assert.Equal("olleh", StringHelpers.Reverse("hello"));
        Assert.Equal("A", StringHelpers.Reverse("A"));
        Assert.Equal("12321", StringHelpers.Reverse("12321"));

        // edge cases: empty and null
        Assert.Equal(string.Empty, StringHelpers.Reverse(string.Empty));
        Assert.Null(StringHelpers.Reverse(null));
    }

    [Fact]
    public void CountOccurrences_VariousInputs_ReturnsExpected()
    {
        // normal cases
        Assert.Equal(2, StringHelpers.CountOccurrences("hello world hello", "hello"));
        Assert.Equal(1, StringHelpers.CountOccurrences("foo bar baz", "bar"));
        Assert.Equal(0, StringHelpers.CountOccurrences("repeat repeat", "nope"));

        // case insensitivity (three occurrences due to every word matching ignoring case)
        Assert.Equal(3, StringHelpers.CountOccurrences("TeSt test TEST", "test"));

        // edge cases: sentence or word null/empty
#pragma warning disable CS8625
        Assert.Equal(0, StringHelpers.CountOccurrences(null, "word"));
        Assert.Equal(0, StringHelpers.CountOccurrences("sentence", null));
#pragma warning restore CS8625
        Assert.Equal(0, StringHelpers.CountOccurrences(string.Empty, "word"));
        Assert.Equal(0, StringHelpers.CountOccurrences("sentence", string.Empty));
    }

    [Fact]
    public void ArrayHelpers_Methods_WorkAsExpected()
    {
        // FindMax
        Assert.Equal(5, ArrayHelpers.FindMax(new[] {1, 5, 3}));
        Assert.Equal(int.MinValue, ArrayHelpers.FindMax(null));
        Assert.Equal(int.MinValue, ArrayHelpers.FindMax(Array.Empty<int>()));

        // RemoveDuplicates
        Assert.Equal(new[] {1,2,3}, ArrayHelpers.RemoveDuplicates(new[] {1,2,2,3,1}));
        Assert.Empty(ArrayHelpers.RemoveDuplicates(null));
        Assert.Empty(ArrayHelpers.RemoveDuplicates(Array.Empty<int>()));

        // FlattenArray
        int[,] matrix = { {1,2}, {3,4} };
        Assert.Equal(new[] {1,2,3,4}, ArrayHelpers.FlattenArray(matrix));
        Assert.Empty(ArrayHelpers.FlattenArray(null));
        Assert.Empty(ArrayHelpers.FlattenArray(new int[0,0]));
    }
}
