using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution9
    {
        #region 9. 回文数
        public bool IsPalindrome(int x)
        {
            var xStr = x.ToString();
            var xArr = xStr.ToArray();
            Array.Reverse(xArr);
            return xStr == new string(xArr);
        }
        #endregion
    }
}
