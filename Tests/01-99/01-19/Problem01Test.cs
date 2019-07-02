using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems._01_99._01_19;

namespace Tests
{
	[TestClass]
	public class Problem01Test
	{
		[TestMethod]
		public void ContainsTwoSum_ShouldReturnTrue()
		{
			// Arrange
			int[] nums = { 10, 15, 3, 7 };
			int k = 17;

			// Act
			var result = Problem01.ContainsTwoSum(nums, k);

			// Assert
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void ContainsTwoSum_ShouldReturnFalse()
		{
			// Arrange
			int[] nums = { 3, 19, 12, 5 };
			int k = 14;

			// Act
			var result = Problem01.ContainsTwoSum(nums, k);

			// Assert
			Assert.IsFalse(result);
		}
	}
}
