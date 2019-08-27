using Ctci.ctci.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Ctci.Ch02.LinkedLists.Q2_05_SumLists;

namespace Tests.Ctci_Test.Ch_02._Linked_Lists
{
	[TestClass]
	public class Q2_05_SumLists_Test
	{
		[TestMethod]
		public void SumListsReverseOrder_ShouldReturnCorrectLinkedList()
		{
			// Assign
			var testListA = LinkedListNode.CreateLinkedList(new int[] { 7, 1, 6 });
			var testListB = LinkedListNode.CreateLinkedList(new int[] { 5, 9, 2 });

			// Act
			var resultList = Solution.SumListsReverseOrder(testListA, testListB);

			// Assert
			Assert.AreEqual("2 -> 1 -> 9 -> null", resultList.LinkedListToString());
		}
	}
}
