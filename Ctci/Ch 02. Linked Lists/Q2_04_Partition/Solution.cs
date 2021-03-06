﻿using System;
using System.Collections;
using System.Collections.Generic;
using Ctci.ctci.Library;

namespace Ctci.Ch_02._Linked_Lists.Q2_04_Partition
{
	public class Solution
	{
		// Time: O(n)
		// Space: O(n)
		public static LinkedListNode PartitionLinkedList(LinkedListNode head, int partition)
		{
			var leftList = new List<int>();
			var rightList = new List<int>();

			var current = head;
			while (current != null)
			{
				if (current.Data < partition)
				{
					leftList.Add(current.Data);
				}
				else
				{
					rightList.Add(current.Data);
				}
				current = current.Next;
			}

			// concat rightList to end of the leftList
			leftList.AddRange(rightList);

			return LinkedListNode.CreateLinkedList(leftList);
		}
	}
}
