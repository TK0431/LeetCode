using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class C0028
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrWhiteSpace(needle)) return 0;
            if (needle.Length > haystack.Length) return -1;

            Dictionary<int, string> set = new Dictionary<int, string>();
            string str = haystack.Substring(0, needle.Length);
            set.Add(0, str.ToString());
            int i = 1;
            foreach (char c in haystack.Substring(needle.Length))
            {
                str = str.Substring(1) + c;
                set.Add(i++, str.ToString());
            }

            foreach (int key in set.Keys)
            {
                if (set[key] == needle) return key;
            }
            return -1;
        }
    }
}
