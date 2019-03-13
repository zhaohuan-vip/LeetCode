using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution8
    {
        #region 8. 字符串转整数 (atoi)
        public int MyAtoi(string str)
        {
            int result = 0;
            string numStr = "";
            string[] numsCharArr = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", "+" };

            str = str.TrimStart();
            for (int i = 0; i < str.Length; i++)
            {
                int index = Array.IndexOf(numsCharArr, str[i].ToString());
                if (index < 0)
                {
                    if (i == 0)
                    {
                        numStr = "0";
                    }
                    break;
                }
                else
                {
                    if (i != 0 && (str[i] == '-' || str[i] == '+'))
                    {
                        break;
                    }
                    else
                    {
                        numStr += str[i];
                    }

                }
            }
            try
            {
                result = Convert.ToInt32(numStr);
            }
            catch (Exception ex)
            {
                if (ex.GetType().Name == "OverflowException")
                {
                    result = numStr.IndexOf('-') >= 0 ? int.MinValue : int.MaxValue;
                }
            }

            return result;
        }
        #endregion
    }
}
