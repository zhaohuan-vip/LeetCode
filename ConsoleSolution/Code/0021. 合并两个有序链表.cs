using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution.Code
{
    class Solution21
    {
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
    }
}
