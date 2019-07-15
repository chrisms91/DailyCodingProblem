using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests._01_99._01_19
{
	[TestClass]
	public class Problem04Test
	{
		[TestMethod]
		public void FindFirstMissingPositive_ShouldReturnCorrectInteger()
		{
			// Assign
			int[] nums = { 3, 4, -1, 1 };
			int[] nums1 = { 7, 8, 9, 10, 11 };

			// Act
			var result = Problems._01_99._01_19.Problem04.Solution.FindFirstMissingPositive(nums);
			var result1 = Problems._01_99._01_19.Problem04.Solution.FindFirstMissingPositive(nums1);

			// Assert
			Assert.AreEqual(2, result);
			Assert.AreEqual(1, result1);
		}

		[TestMethod]
		public void FindFirstMissingPositiveLinear_ShouldReturnCorrectOutput()
		{
			// Assign
			int[] nums = { 3, 4, -1, 1 };
			int[] nums1 = { 7, 8, 9, 10, 11 };

			// Act
			var result = Problems._01_99._01_19.Problem04.Solution.FindFirstMissingPositiveLinear(nums);
			var result1 = Problems._01_99._01_19.Problem04.Solution.FindFirstMissingPositiveLinear(nums1);

			// Assert
			Assert.AreEqual(2, result);
			Assert.AreEqual(1, result1);
		}
	}
}
