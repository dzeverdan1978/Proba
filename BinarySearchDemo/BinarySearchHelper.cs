using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchDemo
{
    public static class BinarySearchHelper
    {
        public static int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        public static int BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
            try
            {
                if (min > max)
                {
                    return -2;
                }
                else
                {
                    int mid = (min + max) / 2;
                    if (key == inputArray[mid])
                    {
                        return ++mid;
                    }
                    else if (key < inputArray[mid])
                    {
                        return BinarySearchRecursive(inputArray, key, min, mid - 1);
                    }
                    else
                    {
                        return BinarySearchRecursive(inputArray, key, mid + 1, max);
                    }
                }
            }
            catch
            {
                return -3;
            }
        }
    }
}
