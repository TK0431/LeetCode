using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class C0238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] LSum = GetSumLeft(nums);
            int[] RSum = GetSumRight(nums, false);

            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = LSum[i] * RSum[i];
            }
            return result;
        }

        private int[] GetSumLeft(int[] nums, bool isLeft = true)
        {
            int[] result = new int[nums.Length];

            result[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] * nums[i - 1];
            }
            return result;
        }

        private int[] GetSumRight(int[] nums, bool isLeft = true)
        {
            int[] result = new int[nums.Length];

            result[nums.Length - 1] = 1;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                result[i] = result[i + 1] * nums[i + 1];
            }
            return result;
        }
    }
}
