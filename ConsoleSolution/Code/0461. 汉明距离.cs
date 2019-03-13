using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution461
    {
        #region 461. 汉明距离
        /*
         * 两个整数之间的汉明距离指的是这两个数字对应二进制位不同的位置的数目。
         * 给出两个整数 x 和 y，计算它们之间的汉明距离。
         * */
        public int HammingDistance(int x, int y)
        {
            return Convert.ToString(x ^ y, 2).Count(m => m == '1');
        }
        #endregion
    }
}
