using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution11
    {
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
    }
}
