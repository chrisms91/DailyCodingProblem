using System;
using System.Collections.Generic;
using System.Text;
using Problems.Common;

namespace Problems._01_99._01_19.Problem03
{
	public class Solution
	{
		private const string MARKER = "1";

		public static string Serialize(Node<string> node)
		{
			if (node == null)
			{
				return MARKER + '-';
			}

			var sb = new StringBuilder();
			sb.Append($"{node.Value}-");

			sb.Append(Serialize(node.Left));
			sb.Append(Serialize(node.Right));

			return sb.ToString();
		}

		public static Node<string> Deserialize(string serializedNode)
		{
			var serializedNodeArr = serializedNode.Split('-');

			var queue = new Queue<string>(serializedNodeArr);

			var deserializedNode = DeserializeNode(queue);

			return deserializedNode;
		}

		public static Node<string> DeserializeNode(Queue<string> nodeStringQueue)
		{
			if (nodeStringQueue.Peek() != null)
			{
				var currentNodeString = nodeStringQueue.Dequeue();

				if (currentNodeString == MARKER)
				{
					return null;
				}

				var node = new Node<string>(currentNodeString)
				{
					Left = DeserializeNode(nodeStringQueue),
					Right = DeserializeNode(nodeStringQueue)
				};

				return node;
			}

			return null;
		}
	}
}
