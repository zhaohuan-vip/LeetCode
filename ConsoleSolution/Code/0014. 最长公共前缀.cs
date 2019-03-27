using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    public class Solution14
    {
        public string LongestCommonPrefix(string[] strs)
        {
            // 二分法解题思路
            if (strs == null || strs.Length == 0) return "";
            int minLen = strs.Min(m => m.Length);
            int start = 0, end = minLen;
            int mid = minLen / 2;
            bool add = false;
            while (end - start > 1)
            {
                add = isCommonChar(strs, mid);
                if (add)
                {
                    start = mid;
                }
                else
                {
                    end = mid;
                }
                mid = (start + end) / 2;
            }
            return strs[0].Substring(0, isCommonChar(strs, end) ? end : start);
        }

        public bool isCommonChar(string[] strs, int mid)
        {
            string tempPre = strs[0].Substring(0, mid);
            for (int i = 0; i < strs.Length; i++)
            {
                if (!strs[i].StartsWith(tempPre))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
