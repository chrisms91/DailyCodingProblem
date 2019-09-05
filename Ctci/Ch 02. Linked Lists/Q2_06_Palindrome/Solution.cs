using Ctci.ctci.Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ctci.Ch_02._Linked_Lists.Q2_06_Palindrome
{
	public class Solution
	{
		public static bool IsPalindrome(LinkedListNode head)
		{
			if (head == null) return false;

			// Initialize
			var curr = head;
			var stack = new Stack();

			// Iterate through linkedlist and push node to the stack
			while (curr != null)
			{
				stack.Push(curr.Data);
				curr = curr.Next;
			}

			curr = head;
			while (curr != null)
			{
				var popped = stack.Pop();
				if (curr.Data != popped)
				{
					return false;
				}
			}

		}
	}
}
