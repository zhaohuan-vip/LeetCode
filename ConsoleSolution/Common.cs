using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSolution
{
    public class Common
    {
        #region 集合转链表
        /// <summary>
        /// 集合转链表
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <returns>ListNode.</returns>
        public ListNode ArrToListNode(int[] arr)
        {

            ListNode temp = new ListNode(0);
            ListNode resultLn = null;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    temp = new ListNode(arr[i]);
                    resultLn = temp;
                }
                else
                {
                    temp.next = new ListNode(arr[i]);
                    temp = temp.next;
                }
            }
            return resultLn;
        }
        #endregion
    }
}
