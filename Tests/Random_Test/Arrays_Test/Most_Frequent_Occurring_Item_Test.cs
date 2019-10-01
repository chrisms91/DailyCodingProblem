using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Problems.Random.Arrays.Most_Frequent_Occurring_Item;

namespace Tests.Random_Test.Arrays_Test
{
	[TestClass]
	public class Most_Frequent_Occurring_Item_Test
	{
		[TestMethod]
		public void Most_Frequent_ShouldReturnItem()
		{
			// Assign
			// mostFrequent(array1) should return 1.
			int[] array1 = { 1, 3, 1, 3, 2, 1 };
			// mostFrequent(array2) should return 3.
			int[] array2 = { 3, 3, 1, 3, 2, 1 };
			// mostFrequent(array3) should return -1.
			int[] array3 = { };
			// mostFrequent(array4) should return 0.
			int[] array4 = { 0 };
			// mostFrequent(array5) should return -1.
			int[] array5 = { 0, -1, 10, 10, -1, 10, -1, -1, -1, 1 };

			// Act
			var res1 = Solution.MostFrequent(array1);
			var res2 = Solution.MostFrequent(array2);
			var res3 = Solution.MostFrequent(array3);
			var res4 = Solution.MostFrequent(array4);
			var res5 = Solution.MostFrequent(array5);

			// Assert
			Assert.AreEqual(1, res1);
			Assert.AreEqual(3, res2);
			Assert.AreEqual(null, res3);
			Assert.AreEqual(0, res4);
			Assert.AreEqual(-1, res5);
		}
	}
}
