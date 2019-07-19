using Problems.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problems._01_99._01_19.Problem08
{
	public class BinaryTree<T>
	{
		private readonly Node<T> root;

		public BinaryTree(Node<T> root)
		{
			this.root = root;
		}

		public int GetCountUnivalTree()
		{
			return CountUnivalTree(root);
		}

		private int CountUnivalTree(Node<T> root)
		{
			var result = 0;

			if (IsUnival(root))
			{
				result += 1;
			}

			if (root.Left != null)
			{
				result += CountUnivalTree(root.Left);
			}

			if (root.Right != null)
			{
				result += CountUnivalTree(root.Right);
			}

			return result;
		}

		private bool IsUnival(Node<T> root)
		{
			if (root == null) return true;

			if (root.Left != null)
			{
				if (!root.Value.Equals(root.Left.Value))
				{
					return false;
				}
			}

			if (root.Right != null)
			{
				if (!root.Value.Equals(root.Right.Value))
				{
					return false;
				}
			}

			// check subtree recursively
			if (IsUnival(root.Left) && IsUnival(root.Right))
			{
				return true;
			}

			return false;
		}
	}
}
