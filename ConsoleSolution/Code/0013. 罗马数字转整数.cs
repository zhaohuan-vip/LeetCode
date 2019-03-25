using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    public class Solution13
    {
        public int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<string, int> dic = new Dictionary<string, int>()
            {
                {"I",1},
                {"V",5},
                {"X",10},
                {"L",50},
                {"C",100},
                {"D",500},
                {"M",1000},
            };
            Dictionary<string, int> dic49 = new Dictionary<string, int>()
            {
                {"IV",4},
                {"IX",9},
                {"XL",40},
                {"XC",90},
                {"CD",400},
                {"CM",900}
            };
            foreach (string key in dic49.Keys)
            {
                if (s.IndexOf(key) >= 0)
                {
                    result += dic49[key];
                    s = s.Replace(key, "");
                }
            }

            foreach (char k1 in s)
            {
                result += dic[k1.ToString()];
            }

            return result;
        }
    }
}
