using System;
using System.Collections.Generic;
using System.Text;
using Ctci.ctci.Library;

namespace Ctci.Ch_02._Linked_Lists.Q2_01_Remove_Duplication
{
	public static class Solution
	{
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
	}
}
