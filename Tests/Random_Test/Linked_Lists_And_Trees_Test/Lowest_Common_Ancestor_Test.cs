using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Common;
using Problems.Random.Linked_Lists_And_Trees.Lowest_Common_Ancestor;

namespace Tests.Random_Test.Linked_Lists_And_Trees_Test
{
	[TestClass]
	public class Lowest_Common_Ancestor_Test
	{
		[TestMethod]
		public void LowestCommonAncestor_ShouldReturnCorrectNode()
		{
			// Assign
			/*
			 * head =  5
								/ \
							 1   4
							/ \ / \
						 3  8 9  2
						/ \
					 6   7
			 * 
			 */
			var root = new Node<int>(5,
			 new Node<int>(1, new Node<int>(3, new Node<int>(6), new Node<int>(7)), new Node<int>(8)),
			 new Node<int>(4, new Node<int>(9), new Node<int>(2)));

			// Act
			var result = Solution.Lca(root, 8, 7);
			var result1 = Solution.Lca(root, 4, 2);

			// Assert
			Assert.AreEqual(result.Value, 1);
			Assert.AreEqual(result1.Value, 4);
		}
	}
}
