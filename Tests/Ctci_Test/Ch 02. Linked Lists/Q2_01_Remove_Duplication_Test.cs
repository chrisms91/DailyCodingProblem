using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ctci.ctci.Library;
using Ctci.Ch_02._Linked_Lists.Q2_01_Remove_Duplication;
namespace Tests.Ctci_Test.Ch_02._Linked_Lists
{
	[TestClass]
	public class Q2_01_Remove_Duplication_Test
	{
		[TestMethod]
		public void RemoveDup_ShouldRemoveDuplicateNode()
		{
			// Assign
			var test = LinkedListNode.CreateLinkedList(new int[] { 2, 3, 3, 3, 1, 4, 2, 1, 5 });
			var test1 = LinkedListNode.CreateLinkedList(new int[] { 1, 1, 1, 1, 1, 1 });

			// Act
			//var result = Solution.RemoveDup(test);
			//var result1 = Solution.RemoveDup(test1);

            var result = Solution.RemoveDupTwo(test);
            var result1 = Solution.RemoveDupTwo(test1);

            // Assert
            Assert.AreEqual("2 -> 3 -> 1 -> 4 -> 5 -> null", result.LinkedListToString());
			Assert.AreEqual("1 -> null", result1.LinkedListToString());
		}
	}
}
