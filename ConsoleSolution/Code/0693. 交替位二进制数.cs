using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution693
    {
        #region 693. 交替位二进制数
        /*
         * 给定一个正整数，检查他是否为交替位二进制数：换句话说，就是他的二进制数相邻的两个位数永不相等。
         * */
        public bool HasAlternatingBits(int n)
        {
            // 转二进制
            var n2 = Convert.ToString(n, 2);
            return !n2.Contains("11") && !n2.Contains("00");
        }
        #endregion
    }
}
