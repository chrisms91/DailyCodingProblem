using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ctci.Ch_01._Arrays_and_Strings.Q1_06_String_Compression;

namespace Tests.Ctci_Test.Ch_01._Arrays_and_Strings
{
	[TestClass]
	public class Q1_06_String_Compressed_Test
	{
		[TestMethod]
		public void StringCompression_ShouldReturnCompressedString()
		{
			// Assign
			var testStr = "aabcccccaaa";
			var testStr1 = "abbccccccccdee";

			// Act
			var res = Solution.StringCompression(testStr);
			var res1 = Solution.StringCompression(testStr1);

			// Assert
			Assert.AreEqual("a2b1c5a3", res);
			Assert.AreEqual("a1b2c8d1e2", res1);
		}
	}
}
