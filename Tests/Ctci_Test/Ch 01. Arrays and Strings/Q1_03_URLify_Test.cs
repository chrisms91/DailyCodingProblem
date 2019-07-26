using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Ctci.Ch_01._Arrays_and_Strings.Q1_03_URLify;

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

			// Assert
			Assert.AreEqual("abc%20d%20e", new string(charArray));
		}
	}
}
