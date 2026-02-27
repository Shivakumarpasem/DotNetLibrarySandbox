namespace DotNetLibrarySandbox.Lib
{
    /// <summary>
    /// Utility methods for string operations.
    /// </summary>
    public class StringHelpers
    {
        /// <summary>
        /// Checks if a string is a palindrome.
        /// Example: "racecar" → true, "hello" → false
        /// </summary>
        public static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            string cleaned = input.ToLower();
            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        /// <summary>
        /// Reverses a string.
        /// Example: "hello" → "olleh"
        /// </summary>
        public static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        /// <summary>
        /// Counts how many times a word appears in a sentence.
        /// Example: "hello world hello", "hello" → 2
        /// </summary>
        public static int CountOccurrences(string sentence, string word)
        {
            if (string.IsNullOrEmpty(sentence) || string.IsNullOrEmpty(word)) return 0;

            string[] words = sentence.Split(' ');
            int count = 0;
            foreach (var w in words)
            {
                if (w.ToLower() == word.ToLower())
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Counts the number of vowels in the provided string.
        /// Vowels considered: a, e, i, o, u (case-insensitive).
        /// Returns 0 for null or empty input.
        /// </summary>
        public static int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;

            int count = 0;
            foreach (char ch in input)
            {
                switch (char.ToLowerInvariant(ch))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                }
            }
            return count;
        }

        /// <summary>
        /// Determines whether two strings are anagrams of each other.
        /// Comparison is case-insensitive and ignores whitespace.
        /// Returns false if either input is null or empty.
        /// </summary>
        public static bool AreAnagrams(string first, string second)
        {
            if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(second)) return false;

            var sb1 = new System.Text.StringBuilder();
            foreach (char c in first)
            {
                if (!char.IsWhiteSpace(c)) sb1.Append(char.ToLowerInvariant(c));
            }

            var sb2 = new System.Text.StringBuilder();
            foreach (char c in second)
            {
                if (!char.IsWhiteSpace(c)) sb2.Append(char.ToLowerInvariant(c));
            }

            string s1 = sb1.ToString();
            string s2 = sb2.ToString();

            if (s1.Length != s2.Length) return false;

            char[] arr1 = s1.ToCharArray();
            char[] arr2 = s2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i]) return false;
            }
            return true;
        }
    }
}