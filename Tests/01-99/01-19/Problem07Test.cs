using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests._01_99._01_19
{
	[TestClass]
	public class Problem07Test
	{
		[TestMethod]
		public void GetCountDecoding_ShouldReturnCorrectCount()
		{
			// Assign
			char[] digits = { '1', '2', '1' };
			char[] digits1 = { '1', '2', '3', '4' };

			// Act
			var count = Problems._01_99._01_19.Problem07.Solution.GetCountDecoding(digits, digits.Length);
			var count1 = Problems._01_99._01_19.Problem07.Solution.GetCountDecoding(digits1, digits1.Length);

			// Assert
			Assert.AreEqual(3, count);
			Assert.AreEqual(3, count1);
		}
	}
}
