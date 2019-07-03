using System;
using System.Collections.Generic;
using System.Text;

namespace Problems.Common
{
	public class Node<T>
	{
		public Node<T> Right { get; set; }
		public Node<T> Left { get; set; }
		public T Value { get; set; }


		public Node(T value)
		{
			Value = value;
		}

		public Node(T value, Node<T> left, Node<T> right) : this(value)
		{
			Left = left;
			Right = right;
		}
	}
}
