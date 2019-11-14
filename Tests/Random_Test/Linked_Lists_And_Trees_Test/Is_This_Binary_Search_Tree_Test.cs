using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Common;
using Problems.Random.Linked_Lists_And_Trees.Is_This_Binary_Search_Tree;
namespace Tests.Random_Test.Linked_Lists_And_Trees_Test
{
	[TestClass]
	public class Is_This_Binary_Search_Tree_Test
	{
		[TestMethod]
		public void IsBST_ShouldReturnTrue()
		{
			// Assign
			//			3
			//		/   \
			//	 1     5
			//	/ \   / \
			// 0   2 4   6
			var root = new Node<int>(3, 
				new Node<int>(1, new Node<int>(0), new Node<int>(2)), 
				new Node<int>(5, new Node<int>(4), new Node<int>(6)));

			// Act
			var result = Solution.IsBST(root);

			// Assert
			Assert.AreEqual(result, true);
		}

		[TestMethod]
		public void IsBST_ShouldReturnFalse()
		{
			// Assign
			//     0
			//    / \
			//   1   2
			//  / \ / \
			// 3  4 5  6
			var root = new Node<int>(0, 
				new Node<int>(1, new Node<int>(3), new Node<int>(4)), 
				new Node<int>(2, new Node<int>(5), new Node<int>(6)));

			// Act
			var result = Solution.IsBST(root);

			// Assert
			Assert.AreEqual(result, false);
		}
	}
}
