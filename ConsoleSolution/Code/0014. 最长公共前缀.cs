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
            /*
             * 循环改变start到end的位置取中间索引判定是否符合条件，直到start到end之间无字符
             * */
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
            // 确定最终索引是start还是end
            return strs[0].Substring(0, isCommonChar(strs, end) ? end : start);
        }
        /// <summary>
        /// 判定到索引mid的字符串是否是公共字符
        /// </summary>
        /// <param name="strs"></param>
        /// <param name="mid"></param>
        /// <returns></returns>
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
