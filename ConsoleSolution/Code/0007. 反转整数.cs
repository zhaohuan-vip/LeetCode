using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution0007
    {
        #region 7. 反转整数
        /*
         * 给定一个 32 位有符号整数，将整数中的数字进行反转。
         * */
        public int Reverse(int x)
        {
            int result = 0;
            if (x > int.MaxValue || x <= int.MinValue)
            {
                return 0;
            }
            var num = string.Join("", (x >= 0 ? x : 0 - x).ToString().ToArray().Reverse());
            try
            {
                if (x > 0)
                {
                    result = Convert.ToInt32(num);
                }
                else
                {
                    result = 0 - Convert.ToInt32(num);
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().Name == "OverflowException")
                {
                    result = 0;
                }
            }
            return result;
        }
        #endregion
    }
}
