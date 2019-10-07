using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Random.Strings.Non_Repeating_Character;

namespace Tests.Random_Test.Strings_Test
{
	[TestClass]
	public class Non_Repeating_Character_Test
	{
		[TestMethod]
		public void NonRepeatingCharacter_ShouldReturnCorrectCharacter()
		{
			// assign
			var str1 = "abcab"; // should return 'c'
			var str2 = "abab"; // should return null
			var str3 = "aabbbc"; // should return 'c'
			var str4 = "aabbdbc"; // shoudl return 'd'

			// act
			var res1 = Solution.NonRepeatingCharacter(str1);
			var res2 = Solution.NonRepeatingCharacter(str2);
			var res3 = Solution.NonRepeatingCharacter(str3);
			var res4 = Solution.NonRepeatingCharacter(str4);

			// assert
			Assert.AreEqual('c', res1);
			Assert.AreEqual(null, res2);
			Assert.AreEqual('c', res3);
			Assert.AreEqual('d', res4);

		}
	}
}
