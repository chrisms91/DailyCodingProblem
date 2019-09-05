using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Ctci.ctci.Library;
using Ctci.Ch_02._Linked_Lists.Q2_02_KthToLast;



namespace Tests.Ctci_Test.Ch_02._Linked_Lists
{
	[TestClass]
	public class Q2_02_KthToLast_Test
	{
		[TestMethod]
		public void KthToLast_ShouldReturnCorrectValue()
		{
			// Assign
			var testList = LinkedListNode.CreateLinkedList(new int[] { 35, 15, 4, 20, 99, 6 });

			// Act
			var result = Solution.ReturnKthToLast(testList, 3);
			

			// Assert
			Assert.AreEqual(20, result.Data);
		}

		[TestMethod]
		public void KthToLastRecursive_ShouldPrintCorrectValue()
		{
			var testList = LinkedListNode.CreateLinkedList(new int[] { 99, 88, 77, 44, 33, 22, 11, 666, 2 });

			var result = Solution.ReturnKthToLastRecursive(testList, 9);
		}

		[TestMethod]
		public void KthToLastTwoPointers_ShouldReturnCorrectValue()
		{
			// Assign
			var testList = LinkedListNode.CreateLinkedList(new int[] { 35, 15, 4, 20, 99, 6 });

			// Act
			var result = Solution.ReturnKthToLastTwoPointers(testList, 3);

			// Assert
			Assert.AreEqual(20, result.Data);
		}
	}
}
