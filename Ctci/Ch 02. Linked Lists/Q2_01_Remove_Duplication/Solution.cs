using System;
using System.Collections.Generic;
using System.Text;
using Ctci.ctci.Library;

namespace Ctci.Ch_02._Linked_Lists.Q2_01_Remove_Duplication
{
	public static class Solution
	{
		// Time: O(n)
		// Space: O(n)
		public static LinkedListNode RemoveDup(LinkedListNode node)
		{
			if (node == null) return node;

			var hs = new HashSet<int>();
			hs.Add(node.Data);

			var ptrA = node;
			var ptrB = ptrA;

			while (ptrA.Next != null)
			{
				if (hs.Contains(ptrA.Next.Data))
				{
					ptrA = ptrA.Next;
					ptrB.Next = ptrA.Next;
				}
				else
				{
					ptrA = ptrA.Next;
					ptrB = ptrA;
					hs.Add(ptrA.Data);
				}
			}

			return node;
		}

        // Time: O(n)
        // Space: O(n)
        // Shorter with one pointer.
        public static LinkedListNode RemoveDupTwo(LinkedListNode node)
        {
            if (node == null) return node;
            var hs = new HashSet<int>();
            var curr = node;
            hs.Add(curr.Data);

            while(curr.Next != null)
            {
                if (!hs.Contains(curr.Next.Data))
                {
                    hs.Add(curr.Next.Data);
                    curr = curr.Next;
                }
                else
                {
                    curr.Next = curr.Next.Next;
                }
            }

            return node;
        }

		// Time: O(n^2)
		// Space: O(1)
		public static LinkedListNode RemoveDupWithOutBuffer(LinkedListNode node)
		{
			if (node == null) return node;

			var current = node;
			
			while(current != null)
			{
				var runner = current;
				
				while(runner.Next != null)
				{
					if (runner.Next.Data == current.Data)
					{
						runner.Next = runner.Next.Next;
					}
					else
					{
						runner = runner.Next;
					}
				}

				current = current.Next;
			}
			return node;
		}
	}
}
