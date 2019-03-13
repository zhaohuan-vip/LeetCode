using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution2
    {
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
    }
}
