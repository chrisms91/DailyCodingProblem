using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ctci.ctci.Library;
using Problems.Random.Linked_Lists_And_Trees.Nth_From_End;

namespace Tests.Random_Test.Linked_Lists_And_Trees_Test
{
	[TestClass]
	public class Nth_From_End_Test
	{
		[TestMethod]
		public void NthFromEnd_ShouldReturnCorrectNode()
		{
			// Assign
			var head = LinkedListNode.CreateLinkedList(new int[] { 7, 6, 5, 4, 3, 2, 1 });
			var head2 = LinkedListNode.CreateLinkedList(new int[] { 1, 2, 3, 4 });

			// Act
			var res = Solution.NthFromEnd(head, 1); // should return 1
			var res1 = Solution.NthFromEnd(head, 5); // should return 5
			var res2 = Solution.NthFromEnd(head2, 2); // should return 3
			var res3 = Solution.NthFromEnd(head2, 5); // should return null

			// Assert
			Assert.AreEqual(res.Data, 1);
			Assert.AreEqual(res1.Data, 5);
			Assert.AreEqual(res2.Data, 3);
			Assert.IsNull(res3);



		}
	}
}
