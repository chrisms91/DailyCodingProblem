using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Random.Arrays.Is_Rotation;

namespace Tests.Random_Test.Arrays_Test
{
	[TestClass]
	public class Is_Rotation_Test
	{
		[TestMethod]
		public void IsRotation_ShouldReturnTrue()
		{
			// Assign
			int[] array1 = { 1, 2, 3, 4, 5, 6, 7 };

			int[] array2a = { 4, 5, 6, 7, 1, 2, 3 };
			int[] array2b = { 1, 2, 3, 4, 5, 6, 7 };

			// Act
			var result = Solution.IsRotation(array1, array2a);
			var result2 = Solution.IsRotation2(array1, array2b);

			// Assert
			Assert.AreEqual(true, result);
			Assert.AreEqual(true, result2);

		}

		[TestMethod]
		public void IsRotation_ShouldReturnFalse()
		{
			// Assign
			int[] array1 = { 1, 2, 3, 4, 5, 6, 7 };

			int[] array2a = { 4, 5, 6, 7, 8, 1, 2, 3 };
			int[] array2b = { 4, 5, 6, 9, 1, 2, 3 };
			int[] array2c = { 4, 6, 5, 7, 1, 2, 3 };
			int[] array2d = { 4, 5, 6, 7, 0, 2, 3 };

			// Act
			var result = Solution.IsRotation(array1, array2a);
			var result2 = Solution.IsRotation2(array1, array2b);
			var result3 = Solution.IsRotation(array1, array2c);
			var result4 = Solution.IsRotation2(array1, array2d);

			// Assert
			Assert.AreEqual(false, result);
			Assert.AreEqual(false, result2);
			Assert.AreEqual(false, result3);
			Assert.AreEqual(false, result4);

		}
	}
}
