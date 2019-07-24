using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ctci.Ch_01._Arrays_and_Strings.Q1_02_Check_Permutation;

using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Ctci_Test.Ch_01._Arrays_and_Strings
{
	[TestClass]
	public class Q1_02_Check_Permutation_Test
	{
		[TestMethod]
		public void CheckPermutation_ShouldReturnTrue()
		{
			// Assign
			var permPair = new string[] { "apple", "ppela" };
			var permPair1 = new string[] { "computer", "uptremoc" };

			// Act
			var res = Solution.CheckPermutation(permPair[0], permPair[1]);
			var res1 = Solution.CheckPermutation1(permPair1[0], permPair1[1]);

			// Assert
			Assert.AreEqual(true, res);
			Assert.AreEqual(true, res1);
		}
	}
}
