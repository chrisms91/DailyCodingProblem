using System;
using Ctci.ctci.Library;

namespace Ctci.Ch_02._Linked_Lists.Q2_03_Delete_Middle_Node
{
    public static class Solution
    {
        // Time: O(n)
        // Space: O(n)
        // When you have access to the head
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

        // When you only have access to single node.
        public static bool DeleteNode(LinkedListNode node)
        {
            if (node == null || node.Next == null) return false;

            LinkedListNode next = node.Next;
            node.Data = next.Data;
            node.Next = next.Next;

            return true;
        }
    }
}
