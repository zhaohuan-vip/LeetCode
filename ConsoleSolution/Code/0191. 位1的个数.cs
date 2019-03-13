using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution191
    {
        #region 191. 位1的个数
        /*
         * 编写一个函数，输入是一个无符号整数，返回其二进制表达式中数字位数为 ‘1’ 的个数（也被称为汉明重量）。
         * */
        public int HammingWeight(uint n)
        {
            var n2 = Convert.ToString(n, 2);
            return n2.Count(m => m == '1');
        }
        #endregion
    }
}
