using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution3
    {
        #region 3. 无重复字符的最长子串

        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            int i = 0, j = 0;
            HashSet<char> hsChar = new HashSet<char>();

            while (i < s.Length && j < s.Length)
            {
                if (!hsChar.Contains(s[j]))
                {
                    hsChar.Add(s[j++]);
                    maxLength = Math.Max(maxLength, j - i);
                }
                else
                {
                    hsChar.Remove(s[i++]);
                }
            }
            return maxLength;
        }

        #endregion
    }
}
