using Ctci.ctci.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ctci.Ch_02._Linked_Lists.Q2_06_Palindrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Ctci_Test.Ch_02._Linked_Lists
{
	[TestClass]
	public class Q2_06_Palindrome_Test
	{
		[TestMethod]
		public void IsPalindrome_ShouldReturnTrue()
		{
			// Assign
			var testListA = LinkedListNode.CreateLinkedList(new int[] { 7, 1, 6, 2, 6, 1, 7 });
			var testListB = LinkedListNode.CreateLinkedList(new int[] { 7, 1, 6, 6, 1, 7 });

			// Act
			var res = Solution.IsPalindrome(testListA);
			var res1 = Solution.IsPalindrome(testListB);

			// Assert
			Assert.AreEqual(true, res);
			Assert.AreEqual(true, res1);
		}
	}
}
