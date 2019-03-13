using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution217
    {
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
    }
}
