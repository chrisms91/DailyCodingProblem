using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems._01_99._01_19.Problem02;
using System;

namespace Tests._01_99._01_19
{
	[TestClass]
	public class Problem02Test
	{
		[TestMethod]
		public void ProductArrExceptSelf_ShouldReturnCorrectArray()
		{
			// Arrange
			int[] nums = { 1, 2, 3, 4, 5 };
			int[] expectedRes = { 120, 60, 40, 30, 24 };

			// Act
			int[] result = Solution.ProductArrExceptSelfBF(nums);
			
			// Assert
			CollectionAssert.AreEqual(expectedRes, result);
		}
	}
}
