using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Random.Arrays.Common_Elements_In_Two_Sorted_Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Random_Test.Arrays_Test
{
	[TestClass]
	public class Common_Elements_In_Two_Sorted_Arrays_Test
	{
		[TestMethod]
		public void CommonElements_ShouldReturnCorrectArrays()
		{
			// Assign
			int[] array1A = { 1, 3, 4, 6, 7, 9 };
			int[] array2A = { 1, 2, 4, 5, 9, 10 };
			int[] expectedA = { 1, 4, 9 };
			// commonElements(array1A, array2A) should return [1, 4, 9] (an array).

			int[] array1B = { 1, 2, 9, 10, 11, 12 };
			int[] array2B = { 0, 1, 2, 3, 4, 5, 8, 9, 10, 12, 14, 15 };
			int[] expectedB = { 1, 2, 9, 10, 12 };
			// commonElements(array1B, array2B) should return [1, 2, 9, 10, 12] (an array).

			int[] array1C = { 0, 1, 2, 3, 4, 5 };
			int[] array2C = { 6, 7, 8, 9, 10, 11 };
			int[] expectedC = { };
			// common_elements(array1C, array2C) should return [] (an empty array).

			// Act
			var resultA = Solution.CommonElemetns(array1A, array2A);
			var resultB = Solution.CommonElemetns(array1B, array2B);
			var resultC = Solution.CommonElemetns(array1C, array2C);

			// Assert
			CollectionAssert.AreEqual(expectedA, resultA);
			CollectionAssert.AreEqual(expectedB, resultB);
			CollectionAssert.AreEqual(expectedC, resultC);

		}
	}
}
