using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleSolution
{
    public class Solution
    {
        #region 1. 两数之和
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("No two sum solution");
        }
        #endregion

        #region 2. 两数相加
        /*
         * 给定两个非空链表来表示两个非负整数。位数按照逆序方式存储，它们的每个节点只存储单个数字。
         * 将两数相加返回一个新的链表。
         * 你可以假设除了数字 0 之外，这两个数字都不会以零开头。
         * */
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode tempLn1 = l1;
            ListNode tempLn2 = l2;
            int n = 0;
            ListNode temp = new ListNode(0);
            var result = temp;
            while (tempLn1 != null || tempLn2 != null || n != 0)
            {
                var addResult = (tempLn1 != null ? tempLn1.val : 0) + (tempLn2 != null ? tempLn2.val : 0) + n;
                if (addResult / 10 >= 1)
                {
                    n = 1;
                }
                else
                {
                    n = 0;
                }
                temp.val = addResult % 10;
                tempLn1 = tempLn1 != null ? tempLn1.next : null;
                tempLn2 = tempLn2 != null ? tempLn2.next : null;
                if (tempLn1 != null || tempLn2 != null || n > 0)
                {
                    temp.next = new ListNode(0);
                    temp = temp.next;
                }
            }
            return result;
        }
        #endregion

        #region 217. 存在重复元素
        /*
         * 给定一个整数数组，判断是否存在重复元素。
         * 如果任何值在数组中出现至少两次，函数返回 true。如果数组中每个元素都不相同，则返回 false。
         * */
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.GroupBy(m => m).Count(m => m.Count() > 1) > 0;
        }
        #endregion

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

        #region 21. 合并两个有序链表
        /*
         * 将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 
         * */
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            List<int> list = new List<int>();
            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    list.Add(l1.val);
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    list.Add(l2.val);
                    l2 = l2.next;
                }

            }
            list = list.OrderBy(m => m).ToList();
            ListNode temp = new ListNode(0);
            ListNode resultLn = null;
            for (int i = 0; i < list.Count(); i++)
            {
                if (i == 0)
                {
                    temp = new ListNode(list[i]);
                    resultLn = temp;
                }
                else
                {
                    temp.next = new ListNode(list[i]);
                    temp = temp.next;
                }
            }
            return resultLn;
        }
        #endregion

        #region 693. 交替位二进制数
        /*
         * 给定一个正整数，检查他是否为交替位二进制数：换句话说，就是他的二进制数相邻的两个位数永不相等。
         * */
        public bool HasAlternatingBits(int n)
        {
            // 转二进制
            var n2 = Convert.ToString(n, 2);
            return !n2.Contains("11") && !n2.Contains("00");
        }
        #endregion

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

        #region 402. 移掉K位数字
        /*
         * 给定一个以字符串表示的非负整数 num，移除这个数中的 k 位数字，使得剩下的数字最小。
         * */
        public string RemoveKdigits(string num, int k)
        {
            string ret = "";
            // 剩余位数即得到结果理论位数
            int surplusKdigits = num.Length - k;
            StringBuilder s = new StringBuilder();
            int startIndex = 0;
            int endIndex = num.Length - 1;
            string tempStr = "";
            var minNum = "";
            for (int i = 0; i < surplusKdigits; i++)
            {
                tempStr = num.Substring(startIndex, k + 1 + i - startIndex);
                minNum = tempStr.Min().ToString(); // 最小值
                startIndex = startIndex + tempStr.IndexOf(minNum) + 1;// 最小值索引 用作下次循环检索截取字符串
                s.Append(minNum);
            }
            ret = s.ToString().TrimStart('0');
            return string.IsNullOrEmpty(ret) ? "0" : ret;
        }
        #endregion

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

        #region 771. 宝石与石头
        /*
         * 给定字符串J 代表石头中宝石的类型，和字符串 S代表你拥有的石头。 S 中每个字符代表了一种你拥有的石头的类型，
         * 你想知道你拥有的石头中有多少是宝石。J 中的字母不重复，J 和 S中的所有字符都是字母。
         * 字母区分大小写，因此"a"和"A"是不同类型的石头。
         * */
        public int NumJewelsInStones(string J, string S)
        {
            int result = 0;
            S.ToList().ForEach(m => result = J.IndexOf(m) >= 0 ? result + 1 : result);
            return result;
        }
        #endregion

        #region 709. 转换成小写字母
        public string ToLowerCase(string str)
        {
            return str.ToLower();
        }
        #endregion

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

        #region 9. 回文数
        public bool IsPalindrome(int x)
        {
            var xStr = x.ToString();
            var xArr = xStr.ToArray();
            Array.Reverse(xArr);
            return xStr == new string(xArr);
        }
        #endregion

        #region 11. 盛最多水的容器
        public int MaxArea(int[] height)
        {
            int max = 0;
            int temp = 0;
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    temp = (height[i] > height[j] ? height[j] : height[i]) * (j - i);
                    if (temp > max)
                    {
                        max = temp;
                    }
                }
            }
            return max;
        }
        #endregion

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
