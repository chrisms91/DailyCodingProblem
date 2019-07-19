using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests._01_99._01_19
{
	[TestClass]
	public class Problem08Test
	{
		[TestMethod]
		public void CountUnivalTree_ShouldReturnCorrectCount()
		{
			// Assign
			var root = new Node<int>(0, new Node<int>(1), new Node<int>(0, new Node<int>(1, new Node<int>(1), new Node<int>(1)), new Node<int>(0)));

			//			a
			//		 / \
			//		c   b
			//			 / \
			//      b   b
			//           \
			//            b
			var root1 = new Node<char>('a', new Node<char>('c'), new Node<char>('b', new Node<char>('b'), new Node<char>('b', null, new Node<char>('b'))));

			var tree = new Problems._01_99._01_19.Problem08.BinaryTree<int>(root);
			var tree1 = new Problems._01_99._01_19.Problem08.BinaryTree<char>(root1);

			// Act
			var count = tree.GetCountUnivalTree();
			var count1 = tree1.GetCountUnivalTree();
			


			// Assert
			Assert.AreEqual(5, count);
			Assert.AreEqual(5, count1);

		}
	}
}
