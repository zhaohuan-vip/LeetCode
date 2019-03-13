using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution524
    {
        #region 524. 通过删除字母匹配到字典里最长单词
        /* 给定一个字符串和一个字符串字典，找到字典里面最长的字符串，该字符串可以通过删除给定字符串的某些字符来得到。
         * 如果答案不止一个，返回长度最长且字典顺序最小的字符串。如果答案不存在，则返回空字符串。
         * */
        public string FindLongestWord(string s, IList<string> d)
        {
            string result = "";
            int tempIndex = 0;  // 记录匹配到的最小索引
            int charIndex = 0;
            int startIndex = 0; // 搜索字符开始索引
            for (int i = 0; i < d.Count; i++)
            {
                for (int j = 0; j < d[i].Length; j++)
                {
                    charIndex = s.IndexOf(d[i][j], startIndex);

                    if (charIndex >= 0)
                    {
                        startIndex = charIndex + 1;
                        if (j == d[i].Length - 1)
                        {
                            if (d[i].Length > result.Length)
                            {
                                tempIndex = i;
                                result = d[i];
                                startIndex = 0;
                            }
                            else if (d[i].Length == result.Length)
                            {
                                if (string.Compare(result, d[i]) > 0)
                                {
                                    tempIndex = i;
                                    result = d[i];
                                    startIndex = 0;
                                }
                            }
                        }
                        continue;
                    }
                    else
                    {
                        startIndex = 0;
                        break;
                    }
                }
            }
            return result;
        }
        #endregion
    }
}
