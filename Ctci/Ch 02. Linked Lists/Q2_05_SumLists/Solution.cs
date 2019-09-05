using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ctci.ctci.Library;

namespace Ctci.Ch_02._Linked_Lists.Q2_05_SumLists
{
	public class Solution
	{
		public static LinkedListNode SumListsReverseOrder(LinkedListNode headA, LinkedListNode headB)
		{
			var numberA = LinkedListToIntReverseOrder(headA);
			var numberB = LinkedListToIntReverseOrder(headB);
			var sum = numberA + numberB;
			var sumIntList = sum.ToString().Select(c => int.Parse(c.ToString())).ToList();
			var result = IntListToLinkedListReverseOrder(sumIntList);
			return result;
		}

		private static LinkedListNode IntListToLinkedListReverseOrder(IList<int> nums)
		{
			var length = nums.Count;
			if (length == 0)
			{
				return null;
			}

			if (length == 1)
			{
				return new LinkedListNode(nums[length - 1]);
			}

			var n = new LinkedListNode(nums[length - 1]);
			var head = n;
			for (var i = length - 2; i >= 0; i--)
			{
				var next = new LinkedListNode(nums[i]);
				n.Next = next;                                                                                                                                                                                                                                                                                                                                                                                                            
				n = next;
			}

			return head;
		}

		private static int LinkedListToIntReverseOrder(LinkedListNode head)
		{
			if (head == null)
			{
				return -1;
			}

			var sb = new StringBuilder();
			var current = head;

			while(current != null)
			{
				sb.Insert(0, current.Data);
				current = current.Next;
			}

			var reversedStringList = sb.ToString();
			if (int.TryParse(reversedStringList, out int res))
			{
				return res;
			}
			else
			{
				return -1;
			}
		}
	}
}
