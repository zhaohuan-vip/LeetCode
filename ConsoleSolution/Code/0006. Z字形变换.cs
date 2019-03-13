using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution0006
    {
        #region 6. Z字形变换
        /*
         * 将字符串 "PAYPALISHIRING" 以Z字形排列成给定的行数：
         * 
         * P   A   H   N
         * A P L S I I G
         * Y   I   R
         * 之后从左往右，逐行读取字符："PAHNAPLSIIGYIR"
         *
         * 实现一个将字符串进行指定行数变换的函数:
         *
         * string convert(string s, int numRows);
         * 
         * */
        public string ConvertZ(string s, int numRows)
        {
            string result = "";
            if (numRows == 1)
            {
                result = s;
            }
            else
            {
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (j == 0 && i == 0)
                        {
                            result += s[j];
                        }
                        else if ((j - i) % (numRows * 2 - 2) == 0 || (j + i) % (numRows * 2 - 2) == 0)
                        {
                            result += s[j];
                        }
                    }
                }
            }
            return result;
        }
        #endregion

    }
}
