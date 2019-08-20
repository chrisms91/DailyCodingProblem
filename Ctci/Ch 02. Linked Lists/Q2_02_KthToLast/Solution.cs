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
    }
}
