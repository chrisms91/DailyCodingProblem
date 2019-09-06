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
			(int lengthA, LinkedListNode lastNodeA) resultA = CalculateLengthAndGetLastNode(headA);
			(int lengthB, LinkedListNode lastNodeB) resultB = CalculateLengthAndGetLastNode(headB);

			// if last node is different, return null..
			if (resultA.lastNodeA != resultB.lastNodeB) return null;

			// if length is diff, move pointer of longer list forward to match the starting point

			// iterate pointers and check if there is intersection (ptrA.next == ptrB.next)

			// return pointer if there is intersection.
			return null;
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
