using System;
using System.Text;

namespace Ctci.ctci.Library
{
	// Most of implementations are from the book.
	public class LinkedListNode
	{
		public LinkedListNode Next { get; set; }
		public int Data { get; set; }

		public LinkedListNode(int d)
		{
			Data = d;
		}

		public void AppendToTail(int d)
		{
			LinkedListNode end = new LinkedListNode(d);
			LinkedListNode n = this;
			while (n.Next != null)
			{
				n = n.Next;
			}
			n.Next = end;
		}

		public static LinkedListNode CreateLinkedList(int[] nums)
		{
			LinkedListNode n = new LinkedListNode(nums[0]);
			LinkedListNode head = n;
			for (int i = 1; i < nums.Length; i++)
			{
				LinkedListNode next = new LinkedListNode(nums[i]);
				n.Next = next;
				n = next;
			}
			return head;
		}

		public static void PrintNode(LinkedListNode head)
		{
			while (head != null)
			{
				Console.Write(head.Data);
				Console.Write(" -> ");
				head = head.Next;
			}
			Console.Write("null\n");
		}
	}
}
