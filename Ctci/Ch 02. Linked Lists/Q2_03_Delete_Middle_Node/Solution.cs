using System;
using Ctci.ctci.Library;

namespace Ctci.Ch02.LinkedLists.Q2_03_Delete_Middle_Node
{
    public static class Solution
    {
        // Time: O(n)
        // Space: O(n)
        public static void DeleteMiddleNode(LinkedListNode head)
        {
            if (head == null) return;

            var slow = head;
            var fast = head;
            var prev = head;

            while(fast.Next.Next != null && fast.Next != null)
            {
                prev = slow;
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            prev.Next = slow.Next;
        }
    }
}
