using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Ctci.Ch_01._Arrays_and_Strings.Q1_03_URLify;
using System.Linq;

namespace Tests.Ctci_Test.Ch_01._Arrays_and_Strings
{
	[TestClass]
	public class Q1_03_URLify_Test
	{
		[TestMethod]
		public void ReplaceSpaces_ShouldReturnCorrectCharArray()
		{
			// Assign
			string inputStr = "abc d e";
			var charArray = new char[inputStr.Length + 3 * 2 + 1];
			for (var i = 0; i < inputStr.Length; i++)
			{
				charArray[i] = inputStr[i];
			}

			// Act
			Solution.ReplaceSpaces(charArray, inputStr.Length);
      var sb = new StringBuilder();
      foreach (var c in charArray)
      {
          if (c != '\0') sb.Append(c);
      }

      // Assert
			Assert.AreEqual("abc%20d%20e", sb.ToString());
		}
	}
}
