using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    public class Solution992
    {
        /*
         * 给定一个正整数数组 A，如果 A 的某个子数组中不同整数的个数恰好为 K，则称 A 的这个连续、不一定独立的子数组为好子数组。
         * 例如，[1,2,3,1,2] 中有 3 个不同的整数：1，2，以及 3。）
         * 返回 A 中好子数组的数目。
         * */
        public int SubarraysWithKDistinct(int[] A, int K)
        {
            int result = 0;
            // 验证窗口
            int ai = 0;
            // 验证集合窗口
            int hsi = 0;
            // 验证集合数组
            List<int> ls = new List<int>();
            List<int> ls2 = new List<int>();
            // 统计不同的字符数
            int differentCount = 0, differentCount2 = 0;
            int temp = 0;
            for (int j = 0; j < A.Length; j++)
            {
                if (!ls.Contains(A[j]))
                {
                    differentCount++;
                }
                ls.Add(A[j]);
                if (!ls2.Contains(A[j]))
                {
                    differentCount2++;
                }
                ls2.Add(A[j]);
               

                while (differentCount > K)
                {
                    temp = ls[0];
                    ls.RemoveAt(0);
                    if (!ls.Contains(temp))
                    {
                        differentCount--;
                    }
                    ai++;
                }
                while (differentCount2 >= K)
                {
                    temp = ls2[0];
                    ls2.RemoveAt(0);
                    if (!ls2.Contains(temp))
                    {
                        differentCount2--;
                    }
                    hsi++;
                }
                // 累加循环位置的好数组个数为hsi-ai
                result += hsi - ai;
            }
            return result;
        }
    }
}
