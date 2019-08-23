using System;
using System.Collections.Generic;
using System.Text;

namespace Ctci.ctci.Library
{
	public static class ExtensionMethods
	{
		public static string LinkedListToString(this LinkedListNode head)
		{
			StringBuilder sb = new StringBuilder();
			while (head != null)
			{
				sb.Append(head.Data).Append(" -> ");
				head = head.Next;
			}
			sb.Append("null");
			return sb.ToString();
		}

        public static void AppendToTail(this LinkedListNode n, int data)
        {
            LinkedListNode end = new LinkedListNode(data);
            while (n.Next != null)
            {
                n = n.Next;
            }
            n.Next = end;
        }
	}
}
