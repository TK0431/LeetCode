using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 0009

            //C9 c = new C9();
            //Console.WriteLine(c.IsPalindrome(12321));

            #endregion

            #region 0013

            //C13 c = new C13();
            //Console.WriteLine(c.RomanToInt("MCMXCIV"));

            #endregion

            #region 0020

            //C0020 c = new C0020();
            //Console.WriteLine(c.IsValid("["));

            #endregion

            #region 0026

            //C26 c = new C26();
            //int[] arr = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //Console.WriteLine(c.RemoveDuplicates(arr));
            //arr.ToList().ForEach(x => Console.Write(x + " "));

            #endregion

            #region 0027

            //C0027 c = new C0027();
            //int[] arr = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            //Console.WriteLine(c.RemoveElement(arr, 2));
            //arr.ToList().ForEach(x => Console.Write(x + " "));

            #endregion

            #region 0028

            //C0028 c = new C0028();
            //Console.WriteLine(c.StrStr("abc", ""));

            #endregion

            #region 0035

            //C0035 c = new C0035();
            //int[] arr = new int[] { 1, 3 };
            //Console.WriteLine(c.SearchInsert(arr,2));

            #endregion

            #region 0038

            C0038 c = new C0038();
            Console.WriteLine(c.CountAndSay(6));

            #endregion

            #region 0238

            //C238 c = new C238();
            //int[] a = new int[] { 1, 2, 3, 4 };
            //int[] b = c.ProductExceptSelf(a);
            //b.ToList().ForEach( x => Console.Write($"{x} "));

            #endregion

        }
    }
}
