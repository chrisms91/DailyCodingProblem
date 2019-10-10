using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Random.Strings.One_Away_Strings;

namespace Tests.Random_Test.Strings_Test
{
	[TestClass]
	public class One_Away_Strings_Test
	{
		[TestMethod]
		public void IsOneAway_ShouldReturnTrue()
		{
			// Assign
			string[] case1 = { "abcde", "abcd" };
			string[] case2 = { "abcd", "abcde" };
			string[] case3 = { "a", "a" };
			string[] case4 = { "abcdef", "abqdef" };
			string[] case5 = { "abcdef", "abcde" };

			// Act
			var result1 = Solution.IsOneAway(case1[0], case1[1]);
			var result2 = Solution.IsOneAway(case2[0], case2[1]);
			var result3 = Solution.IsOneAway(case3[0], case3[1]);
			var result4 = Solution.IsOneAway(case4[0], case4[1]);
			var result5 = Solution.IsOneAway(case5[0], case5[1]);

			// Assert
			Assert.AreEqual(result1, true);
			Assert.AreEqual(result2, true);
			Assert.AreEqual(result3, true);
			Assert.AreEqual(result4, true);
			Assert.AreEqual(result5, true);
		}

		[TestMethod]
		public void IsOneAway_ShouldReturnFalse()
		{
			// Assign
			string[] case1 = { "aaa", "abc" };
			string[] case2 = { "abcde", "abc" };
			string[] case3 = { "abc", "abcde" };
			string[] case4 = { "abc", "bcc" };

			// Act
			var result1 = Solution.IsOneAway(case1[0], case1[1]);
			var result2 = Solution.IsOneAway(case2[0], case2[1]);
			var result3 = Solution.IsOneAway(case3[0], case3[1]);
			var result4 = Solution.IsOneAway(case4[0], case4[1]);

			// Assert
			Assert.AreEqual(result1, false);
			Assert.AreEqual(result2, false);
			Assert.AreEqual(result3, false);
			Assert.AreEqual(result4, false);
		}
	}
}
