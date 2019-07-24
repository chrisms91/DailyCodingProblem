using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ctci.Ch_01._Arrays_and_Strings.Q1_01_Is_Unique;

namespace Tests.Ctci_Test.Ch_01._Arrays_and_Strings
{
	[TestClass]
	public class Q1_01_Is_Unique_Test
	{
		[TestMethod]
		public void IsUnique_ShouldReturnTrue()
		{
			// Assign
			string str = "company";

			// Act
			var res = Solution.IsUnique(str);
			var res1 = Solution.IsUnique1(str);

			// Assert
			Assert.AreEqual(true, res);
			Assert.AreEqual(true, res1);
		} 

		[TestMethod]
		public void IsUnique_ShouldReturnFalse()
		{
			// Assign
			string str = "apple";

			// Act
			var res = Solution.IsUnique(str);
			var res1 = Solution.IsUnique1(str);

			// Assert
			Assert.AreEqual(false, res);
			Assert.AreEqual(false, res1);
		}
	}
}
