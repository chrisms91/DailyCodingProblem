using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ctci.Ch_01._Arrays_and_Strings.Q1_05_One_Away;

namespace Tests.Ctci_Test.Ch_01._Arrays_and_Strings
{
	[TestClass]
	public class Q1_05_One_Away_Test
	{
		[TestMethod]
		public void IsOneAway_ShouldReturnTrue()
		{
			// Assign
			var testSet = new string[] { "pale", "ple" };
			var testSet1 = new string[] { "pales", "pale" };
			var testSet2 = new string[] { "pale", "bale" };

			// Act
			var res = Solution.IsOneAway(testSet[0], testSet[1]);
			var res1 = Solution.IsOneAway(testSet1[0], testSet1[1]);
			var res2 = Solution.IsOneAway(testSet2[1], testSet2[1]);

			// Assert
			Assert.AreEqual(true, res);
			Assert.AreEqual(true, res1);
			Assert.AreEqual(true, res2);
		}
	}
}
