using Ctci.ctci.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Ctci.Ch_02._Linked_Lists.Q2_04_Partition;

namespace Tests.Ctci_Test.Ch_02._Linked_Lists
{
	[TestClass]
	public class Q2_04_Partition_Test
	{
		[TestMethod]
		public void PartitioniLinkedList_ShouldReturnCorrectLinkedList()
		{
			// Assign
			var testList = LinkedListNode.CreateLinkedList(new int[] { 3, 5, 8, 5, 10, 2, 1 });
			var partition = 5;

			// Act
			var resultList = Solution.PartitionLinkedList(testList, partition);

			// Assert
			Assert.AreEqual("3 -> 2 -> 1 -> 5 -> 8 -> 5 -> 10 -> null", resultList.LinkedListToString());
		}
	}
}
