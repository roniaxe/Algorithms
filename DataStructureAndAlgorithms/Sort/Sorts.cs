using System.Collections.Generic;

namespace DataStructureAndAlgorithms.Sort
{
    public static class Sorts<T>
    {
        private static readonly Comparer<T> Comperator = Comparer<T>.Default;

        private static void Swap(T[] arr, int idx1, int idx2)
        {
            var temp = arr[idx1];
            arr[idx1] = arr[idx2];
            arr[idx2] = temp;
        }

        public static T[] BubbleSort(T[] arrayToSort)
        {
            var returnArr = arrayToSort.Clone() as T[];
            if (returnArr != null)
                for (int outer = returnArr.Length - 1; outer > 0; outer--)
                {
                    for (int inner = 0; inner < outer; inner++)
                    {
                        if (Comperator.Compare(returnArr[inner], returnArr[inner + 1]) > 0)
                        {
                            Swap(returnArr, inner, inner + 1);
                        }
                    }
                }

            return returnArr;
        }

        public static void BubbleSortWithWhile(T[] arrayToSort)
        {
            bool loopAgain = true;
            for (int outer = arrayToSort.Length - 1; loopAgain && outer >= 0; outer--)
            {
                loopAgain = false;

                for (int inner = 0; inner < outer; inner++)
                {
                    if (Comperator.Compare(arrayToSort[inner], arrayToSort[inner + 1]) > 0)
                    {
                        Swap(arrayToSort, inner, inner + 1);
                        loopAgain = true;
                    }
                }
            }
        }

        public static T[] SelectionSort(T[] arrayToSort)
        {
            var returnArr = arrayToSort.Clone() as T[];
            if (returnArr != null)
                for (int outer = 0; outer < returnArr.Length; outer++)
                {
                    var min = outer;
                    for (int inner = outer+1; inner < returnArr.Length; inner++)
                    {
                        if (Comperator.Compare(returnArr[min], returnArr[inner]) > 0)
                            min = inner;
                    }

                    Swap(returnArr, outer, min);
                }

            return returnArr;
        }

        public static T[] InsertionSort(T[] arrayToSort)
        {
            var returnArr = arrayToSort.Clone() as T[];
            if (returnArr != null)
            {
                for (int outer = 1; outer < returnArr.Length; outer++)
                {
                    var temp = returnArr[outer];
                    var inIdx = outer;
                    while (inIdx > 0 && Comperator.Compare(returnArr[inIdx - 1], temp) > 0)
                    {
                        returnArr[inIdx] = returnArr[inIdx - 1];
                        inIdx--;
                    }

                    returnArr[inIdx] = temp;
                }
            }


            return returnArr;
        }

        public static int FindKthLargest(int[] nums, int k)
        {
            var result = -1;
            for (int outer = 0; outer < nums.Length; outer++)
            {
                var temp = outer;
                for (int inner = outer + 1; inner < nums.Length; inner++)
                {
                    if (nums[inner] > nums[temp]) temp = inner;
                }

                var tempVal = nums[outer];
                nums[outer] = nums[temp];
                nums[temp] = tempVal;
                if (--k == 0)
                {
                    result = nums[outer];
                    break;
                }
            }

            return result;
        }
    }
}