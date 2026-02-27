using BenchmarkDotNet.Attributes;
using DotNetLibrarySandbox.Lib;

namespace DotNetLibrarySandbox.Tests
{
    [MemoryDiagnoser]
    public class StringHelpersBenchmarks
    {
        private string shortPalindrome;
        private string longText;

        [GlobalSetup]
        public void Setup()
        {
            shortPalindrome = "racecar";
            longText = new string('a', 1000) + "b" + new string('a', 1000);
        }

        [Benchmark]
        public bool IsPalindrome_Short() => StringHelpers.IsPalindrome(shortPalindrome);

        [Benchmark]
        public bool IsPalindrome_Long() => StringHelpers.IsPalindrome(longText);

        [Benchmark]
        public string Reverse_Short() => StringHelpers.Reverse(shortPalindrome);

        [Benchmark]
        public string Reverse_Long() => StringHelpers.Reverse(longText);
    }
}