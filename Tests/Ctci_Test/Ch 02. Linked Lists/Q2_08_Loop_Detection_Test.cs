using Ctci.ctci.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ctci.Ch_02._Linked_Lists.Q2_08_Loop_Detection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Ctci_Test.Ch_02._Linked_Lists
{
	[TestClass]
	public class Q2_08_Loop_Detection_Test
	{
		[TestMethod]
		public void LoopDetection_ShouldReturnCircularNode()
		{
			// Assign
			var testList = new LinkedListNode(1);
			testList.Next = new LinkedListNode(2);
			testList.Next.Next = new LinkedListNode(3);
			testList.Next.Next.Next = new LinkedListNode(4);
			testList.Next.Next.Next.Next = testList.Next;

			// Act
			var result = Solution.LoopDetection(testList);

			// Assert
			Assert.AreEqual(testList.Next, result);
		}

		[TestMethod]
		public void LoopDetection_ShouldReturnNull()
		{
			// Assign
			var testList = LinkedListNode.CreateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 });

			// Act
			var result = Solution.LoopDetection(testList);

			// Assert
			Assert.AreEqual(null, result);
		}
	}
}
