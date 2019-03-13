using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution402
    {
        #region 402. 移掉K位数字
        /*
         * 给定一个以字符串表示的非负整数 num，移除这个数中的 k 位数字，使得剩下的数字最小。
         * */
        public string RemoveKdigits(string num, int k)
        {
            string ret = "";
            // 剩余位数即得到结果理论位数
            int surplusKdigits = num.Length - k;
            StringBuilder s = new StringBuilder();
            int startIndex = 0;
            int endIndex = num.Length - 1;
            string tempStr = "";
            var minNum = "";
            for (int i = 0; i < surplusKdigits; i++)
            {
                tempStr = num.Substring(startIndex, k + 1 + i - startIndex);
                minNum = tempStr.Min().ToString(); // 最小值
                startIndex = startIndex + tempStr.IndexOf(minNum) + 1;// 最小值索引 用作下次循环检索截取字符串
                s.Append(minNum);
            }
            ret = s.ToString().TrimStart('0');
            return string.IsNullOrEmpty(ret) ? "0" : ret;
        }
        #endregion
    }
}
