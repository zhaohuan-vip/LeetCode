﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution771
    {
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
    }
}
