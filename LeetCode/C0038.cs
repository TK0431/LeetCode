using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class C0038
    {
        public string CountAndSay(int n)
        {
            if (n == 1) return "1";
            else
            {
                string str = CountAndSay(n - 1);

                StringBuilder result = new StringBuilder();
                char bk = str[0];
                int cnt =0;
                foreach (char c in str)
                {
                    if (c != bk)
                    {
                        result.Append(cnt.ToString() + bk);
                        bk = c;
                        cnt = 1;
                    }
                    else
                    {
                        cnt++;
                    }
                }
                result.Append(cnt.ToString() + bk);

                return result.ToString();
            }
        }
    }
}
