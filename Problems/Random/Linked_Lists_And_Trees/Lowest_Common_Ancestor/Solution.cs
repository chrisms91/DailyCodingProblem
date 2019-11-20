using Problems.Common;
using System.Collections.Generic;

namespace Problems.Random.Linked_Lists_And_Trees.Lowest_Common_Ancestor
{
	public class Solution
	{
		public static Node<int> Lca(Node<int> root, int x, int y)
		{
			var pathToX = PathToNode(root, x);
			var pathToY = PathToNode(root, y);
			if (pathToX == null || pathToY == null) return null;

			// compare two paths to find lca
			Node<int> currentCommonAncestor = null;
			while (pathToX.Count != 0 && pathToY.Count != 0)
			{
				var xPop = pathToX.Pop();
				var yPop = pathToY.Pop();
				if (xPop == yPop)
				{
					currentCommonAncestor = xPop;
				}
				else
				{
					break;
				}
			}
			return currentCommonAncestor;
		}

		private static Stack<Node<int>> PathToNode(Node<int> root, int x)
		{
			if (root == null) return null;
			if (root.Value == x)
			{
				Stack<Node<int>> stack = new Stack<Node<int>>();
				stack.Push(root);
				return stack;
			}

			Stack<Node<int>> leftPathStack = PathToNode(root.Left, x);
			if (leftPathStack != null)
			{
				leftPathStack.Push(root);
				return leftPathStack;
			}

			Stack<Node<int>> rightPathStack = PathToNode(root.Right, x);
			if (rightPathStack != null)
			{
				rightPathStack.Push(root);
				return rightPathStack;
			}

			return null;
		}
	}
}
