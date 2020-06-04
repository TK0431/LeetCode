using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class C0020
    {
        public bool IsValid(string s)
        {
            if (s.Length % 2 == 1) return false;
            Stack<char> st = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                    st.Push(c);
                else
                {
                    if (st.Count == 0) return false;
                    switch (c)
                    {
                        case ')':
                            if (st.Pop() != '(') return false;
                            break;
                        case '}':
                            if (st.Pop() != '{') return false;
                            break;
                        default:
                            if (st.Pop() != '[') return false;
                            break;
                    }
                }
            }
            return st.Count == 0 ? true : false;
        }
    }
}
