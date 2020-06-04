using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class C0026
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0 || nums == null) return 0;

            int index = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i-1]) continue;
                nums[index++] = nums[i];
            }

            return index;
        }
    }
}
