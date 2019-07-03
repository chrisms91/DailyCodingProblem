using System;
using System.Collections.Generic;
using System.Text;
using Problems.Common;

namespace Problems._01_99._01_19.Problem03
{
	public class Solution
	{
		private const string MARKER = "-1";

		public static string Serealize(Node<string> node)
		{
			if (node == null)
			{
				return MARKER;
			}

			var sb = new StringBuilder();
			sb.Append($"{node.Value}");

			sb.Append(Serealize(node.Left));
			sb.Append(Serealize(node.Right));

			return sb.ToString();
		}
	}
}
