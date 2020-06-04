using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class C0013
    {
        public int RomanToInt(string s)
        {
            int sum = 0;
            char old = '\0';
            foreach (char c in s)
            {
                switch (c)
                {
                    case 'I':
                        sum += 1;
                        break;
                    case 'V':
                        if (old == 'I') sum -= 2;
                        sum += 5;
                        break;
                    case 'X':
                        if (old == 'I') sum -= 2;
                        sum += 10;
                        break;
                    case 'L':
                        if (old == 'X') sum -= 20;
                        sum += 50;
                        break;
                    case 'C':
                        if (old == 'X') sum -= 20;
                        sum += 100;
                        break;
                    case 'D':
                        if (old == 'C') sum -= 200;
                        sum += 500;
                        break;
                    default:
                        if (old == 'C') sum -= 200;
                        sum += 1000;
                        break;
                }
                old = c;
            }

            return sum;
        }
    }
}
