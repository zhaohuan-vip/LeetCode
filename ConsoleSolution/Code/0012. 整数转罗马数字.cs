using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution12
    {
        #region 12. 整数转罗马数字
        public string IntToRoman(int num)
        {
            string result = "";
            var numArr = num.ToString().ToArray();
            Array.Reverse(numArr);
            for (int i = numArr.Count() - 1; i >= 0; i--)
            {
                switch (i)
                {
                    case 0:
                        result += ConvertRomanNum("I", "V", "X", Convert.ToInt32(numArr[i].ToString()));
                        break;
                    case 1:
                        result += ConvertRomanNum("X", "L", "C", Convert.ToInt32(numArr[i].ToString()));
                        break;
                    case 2:
                        result += ConvertRomanNum("C", "D", "M", Convert.ToInt32(numArr[i].ToString()));
                        break;
                    case 3:
                        result += ConvertRomanNum("M", "", "", Convert.ToInt32(numArr[i].ToString()));
                        break;
                }
            }
            return result;
        }

        /// <summary>
        /// 数字转罗马字符
        /// </summary>
        /// <param name="s1">1标识符</param>
        /// <param name="s2">5标识符</param>
        /// <param name="s3">10标识符</param>
        /// <param name="num">数字</param>
        /// <returns></returns>
        public string ConvertRomanNum(string s1, string s2, string s3, int num)
        {
            string[] sArr = {
                                "",
                                s1,
                                s1+s1,
                                s1+s1+s1,
                                s1+s2,
                                s2,
                                s2+s1,
                                s2+s1+s1,
                                s2+s1+s1+s1,
                                s1+s3
                            };
            return sArr[num];
        }
        #endregion
    }
}
