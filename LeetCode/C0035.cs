using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class C0035
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0 || target <= nums[0]) return 0;
            if (target > nums[nums.Length-1]) return nums.Length;
            int left = 0;
            int right = nums.Length - 1;
            int mid = 0;
            do
            {
                mid = (left + right) / 2;
                if (mid == left)
                {
                    if (nums[left] == target) return left;
                    else return right;
                }
                if (nums[mid - 1] < target && target <= nums[mid]) return mid;
                if (nums[mid] < target && target < nums[mid + 1]) return mid + 1;
                if (nums[mid] < target)
                    left = mid + 1;
                else if (nums[mid] > target)
                    right = mid - 1;
                else return mid;
            }
            while (true);
        }
    }
}
