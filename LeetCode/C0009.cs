using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class C0009
    {
        //public bool IsPalindrome(int x)
        //{
        //    if (x < 0) return false;

        //    char[] arr = x.ToString().ToCharArray();
        //    for (int i = 0; i <= (arr.Length - 1) / 2; i++)
        //    {
        //        if (arr[i] != arr[arr.Length - i - 1])
        //            return false;
        //    }

        //    return true;
        //}

        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;

            int rever = 0;
            do
            {
                rever = rever * 10 + x % 10;
                x = x / 10;
            } while (rever < x);

            return rever == x || rever / 10 == x;
        }
    }
}
