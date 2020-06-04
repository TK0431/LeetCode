using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class C0027
    {
        public int RemoveElement(int[] nums, int val)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val) nums[index++] = nums[i];
            }
            return index;
        }
    }
}
