using System;
using System.Collections.Generic;
using System.Text;
using Ctci.ctci.Library;

namespace Ctci.Ch_02._Linked_Lists.Q2_07_Intersection
{
	public class Solution
	{
		public LinkedListNode CheckIntersection(LinkedListNode headA, LinkedListNode headB)
		{
			// calculate length of each list, get the last node of the list and compare
			(int length, LinkedListNode lastNode) resultA = CalculateLengthAndGetLastNode(headA);
			(int length, LinkedListNode lastNode) resultB = CalculateLengthAndGetLastNode(headB);

			// if last node is different, return null..
			if (resultA.lastNode != resultB.lastNode) return null;

			// if length is diff, move pointer of longer list forward to match the starting point
			var longer = resultA.length > resultB.length ? headA : headB;
			var shorter = resultA.length > resultB.length ? headB : headA;

			// iterate pointers and check if there is intersection (ptrA.next == ptrB.next)
			var diff = Math.Abs(resultA.length - resultB.length);
			if (diff > 0)
			{
				var curr = longer;
				while (diff > 0 && curr != null)
				{
					diff--;
					curr = curr.Next;
				}
				longer = curr;
			}

			while (longer != shorter)
			{
				longer = longer.Next;
				shorter = shorter.Next;
			}

			// return pointer if there is intersection.
			return longer;
		}

		private (int length, LinkedListNode lastNode) CalculateLengthAndGetLastNode(LinkedListNode head)
		{
			if (head == null) return (0, null);

			var currentNode = head;
			var length = 1;
			while(currentNode.Next != null)
			{
				length++;
				currentNode = currentNode.Next;
			}

			return (length, currentNode);
		}
	}
}
