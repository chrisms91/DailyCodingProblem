using System;
using Ctci.ctci.Library;

namespace Problems.Random.Linked_Lists_And_Trees.Nth_From_End
{
    public class Solution
    {
        public static LinkedListNode NthFromEnd(LinkedListNode head, int n)
        {
            var ptr1 = head;
            var ptr2 = head;

            // move one pointer1 to nth node
            for (var i = 0; i < n; i++)
            {
                if (ptr1 == null) return null;
                ptr1 = ptr1.Next;
            }

            // move both pointer until pointer1 reaches the end of the list
            while (ptr1 != null)
            {
                ptr1 = ptr1.Next;
                ptr2 = ptr2.Next;
            }

            // return pointer2
            return ptr2;
        }
    }
}
