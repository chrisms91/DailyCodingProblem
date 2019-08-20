using System;
using Ctci.ctci.Library;

namespace Ctci.Ch02.LinkedLists.Q2_02_KthToLast
{
    public class Solution
    {
        // Time: O(n)
        // Space: O(1)
        public static LinkedListNode ReturnKthToLast(LinkedListNode node, int k)
        {
            if (node == null) return node;

            // Calculate Length of Linked List
            var ptr = node;
            var length = 1;

            while (ptr != null)
            {
                ptr = ptr.Next;
                length++;
            }

            // move ptr forward to Length - k
            var position = length - k;
            var targetNode = node;
            while (position >= 0)
            {
                targetNode = targetNode.Next;
                position--;
            }

            // return ptr
            return targetNode;
        }

        // Time: O(n)
        // Space: O(n)
        public static int ReturnKthToLastRecursive(LinkedListNode head, int k)
        {
            if (head == null) return 0;

            var index = ReturnKthToLastRecursive(head.Next, k) + 1;

            if (index == k)
            {
                Console.WriteLine($"{k}th to last node is {head.Data}");
            }

            return index;
        }

        public static LinkedListNode ReturnKthToListIterative(LinkedListNode head, int k)
        {
            var p1 = head;
            var p2 = head;

            // Move p1 to k
            for (var i = 0; i < k; i ++)
            {
                if (p1 == null) return null;
                p1 = p1.Next;
            }

            // Move p1 & p2 until p1 hits null
            while (p1 != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            // return p2
            return p2;
        }
    }
}
