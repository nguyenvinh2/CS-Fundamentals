using System;
using Xunit;
using CS_Fundamentals;

namespace CS_Fundamentals_Test
{
    public class CodeChallengeHardTest
    {
        [Fact]
        public void ArrayPairsTest()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            Assert.Equal(1, CodeChallengeHard.ArrayPairs(input));
        }

        [Fact]
        public void MinimumXORValueTest()
        {
            int[] arr = { 9, 5, 3 };
            Assert.Equal(6, CodeChallengeHard.MinimumXORValue(arr));
        }

        [Fact]
        public void QuickSortTest()
        {
            int[] input = { 7, 68, 65, 32, 2 };
            int[] sorted = { 2, 7, 32, 65, 68 };
            CodeChallengeHard.QuickSort(input, 0, input.Length - 1);
            Assert.Equal(sorted, input);
        }
    }
}
