using System;

namespace DataStructureAndAlgorithms.ArrayAndStrings
{
    public static class Arrays
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] res = new int[2];

            for (int outer = 0; outer < nums.Length; outer++)
            {
                for (int inner = 0; inner < nums.Length; inner++)
                {
                    if (outer == inner) continue;
                    if (nums[outer] + nums[inner] == target)
                    {
                        res[0] = outer;
                        res[1] = inner;
                        return res;
                    }
                }
            }

            return res;
        }

    }
}
