using System;
using Problems.Common;
namespace Problems.Random.Linked_Lists_And_Trees.Is_This_Binary_Search_Tree
{
	public class Solution
	{
		public static bool IsBST(Node<int> head)
		{
			return IsBST(head, null, null);
		}

		public static bool IsBST(Node<int> node, int? leftHead, int? rightHead)
		{
			// base cases
			if (leftHead != null && node.Value > leftHead) return false;
			if (rightHead != null && node.Value < rightHead) return false;

			bool isLeftSubBST = true;
			bool isRightSubBST = true;

			// check left subtree if every nodes are lower than leftHead
			// and right subtree if every nodes are larger than rightHead recursively
			if (node.Left != null)
			{
				isLeftSubBST = IsBST(node.Left, node.Value, rightHead);
			}
			if (node.Right != null)
			{
				isRightSubBST = IsBST(node.Right, leftHead, node.Value);
			}

			return isLeftSubBST && isRightSubBST;
		}
	}
}
