using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution504
    {
        #region 504. 七进制数
        /*
         * 给定一个整数，将其转化为7进制，并以字符串形式输出。
         * */
        public string ConvertToBase7(int num)
        {
            string result = "";
            int temp = Math.Abs(num);
            if (temp == 0)
            {
                result = "0";
            }
            while (temp != 0)
            {
                result = (temp % 7).ToString() + result;
                temp = temp / 7;
            }
            result = num >= 0 ? result : "-" + result;
            return result;
        }
        #endregion
    }
}
