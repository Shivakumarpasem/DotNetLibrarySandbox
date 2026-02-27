namespace DotNetLibrarySandbox.Lib
{
    /// <summary>
    /// Utility methods for working with numeric arrays.
    /// </summary>
    public static class ArrayHelpers
    {
        /// <summary>
        /// Finds the maximum number in the given integer array.
        /// Returns <c>int.MinValue</c> if the array is null or empty.
        /// </summary>
        public static int FindMax(int[]? numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return int.MinValue;

            int max = numbers[0];
            foreach (int n in numbers)
            {
                if (n > max)
                    max = n;
            }
            return max;
        }

        /// <summary>
        /// Returns a new array containing the elements of the input array with duplicates removed.
        /// If the input is null or empty, an empty array is returned.
        /// </summary>
        public static int[] RemoveDuplicates(int[]? numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return Array.Empty<int>();

            var seen = new HashSet<int>();
            var result = new List<int>(numbers.Length);
            foreach (int n in numbers)
            {
                if (seen.Add(n))
                {
                    result.Add(n);
                }
            }
            return result.ToArray();
        }

        /// <summary>
        /// Flattens a 2D integer array into a 1D array.
        /// Null or empty input returns an empty array.
        /// </summary>
        public static int[] FlattenArray(int[,]? matrix)
        {
            if (matrix == null)
                return Array.Empty<int>();

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (rows == 0 || cols == 0)
                return Array.Empty<int>();

            int[] result = new int[rows * cols];
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[index++] = matrix[i, j];
                }
            }
            return result;
        }
    }
}