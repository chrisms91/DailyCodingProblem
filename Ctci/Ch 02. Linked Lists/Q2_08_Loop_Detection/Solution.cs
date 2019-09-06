using System;
using System.Collections.Generic;
using System.Text;
using Ctci.ctci.Library;

namespace Ctci.Ch_02._Linked_Lists.Q2_08_Loop_Detection
{
	public class Solution
	{
		public static LinkedListNode LoopDetection(LinkedListNode head)
		{
			if (head == null) return null;

			var hs = new HashSet<LinkedListNode>();
			var curr = head;
			hs.Add(curr);

			while (curr.Next != null)
			{
				if (hs.Contains(curr.Next))
				{
					return curr.Next;
				}
				else
				{
					hs.Add(curr.Next);
					curr = curr.Next;
				}
			}

			return null;
		}
	}
}
