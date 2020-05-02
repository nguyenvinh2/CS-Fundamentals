using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Fundamentals
{
    public class CodeChallengeHard
    {
        public static int ArrayPairs(int[] input)
        {
            return 0;
        }

        /// <summary>
        /// Given an array of integers. Find the pair in an array which has minimum XOR value.
        /// </summary>
        /// <returns></returns>
        public static int MinimumXORValue(int[] input)
        {
            QuickSort(input, 0, input.Length - 1);
            int val = 0;
            for (int i = 0; i < input.Length - 2; i++)
            {
                val = Math.Min(input[i] ^ input[i + 1], input[i + 1] ^ input[i + 2]);
            }
            return val;
        }

        public static void QuickSort(int[] input, int leftBoundary, int rightBoundary)
        {
            if (leftBoundary < rightBoundary)
            {
                int pivot = Partition(input, leftBoundary, rightBoundary);

                if (pivot > 1)
                {
                    QuickSort(input, leftBoundary, pivot - 1);
                }
                if (pivot + 1 < rightBoundary)
                {
                    QuickSort(input, pivot + 1, rightBoundary);
                }
            }

        }

        private static int Partition(int[] input, int left, int right)
        {
            int pivot = input[left];
            while (true)
            {
                while (input[left] < pivot)
                {
                    left++;
                }
                while (input[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = input[left];
                    input[left] = input[right];
                    input[right] = temp;
                    if (input[left] == input[right])
                    {
                        left++;
                    }
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
