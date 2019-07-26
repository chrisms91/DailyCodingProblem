using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ctci.Ch_01._Arrays_and_Strings.Q1_04_Palindrome_Permutation;


namespace Tests.Ctci_Test.Ch_01._Arrays_and_Strings
{
	[TestClass]
	public class Q1_04_Palindrome_Permutation_Test
	{
		[TestMethod]
		public void IsPermutationOfPalindrome_ShouldReturnTrue()
		{
			// Assign
			var str = "Tact Coa";

			// Act
			var result = Solution.IsPermutationOfPalindrome(str);

			// Assert
			Assert.AreEqual(true, result);
		}

		[TestMethod]
		public void IsPermutationOfPalindrome_ShouldReturnFalse()
		{
			// Assign
			var str = "Abedd c eAAB";

			// Act
			var result = Solution.IsPermutationOfPalindrome(str);

			// Assert
			Assert.AreEqual(false, result);
		}
	}
}
