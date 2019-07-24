using System;
using System.Collections.Generic;
using System.Text;

namespace Ctci.Ch_01._Arrays_and_Strings.Q1_02_Check_Permutation
{
	public class Solution
	{
		// Time: o(nlogn)
		// Space: o(n)
		public static bool CheckPermutation(string original, string valueToTest)
		{
			if (original.Length != valueToTest.Length) return false;

			original = ctci.Library.AssortedMethods.SortString(original);
			valueToTest = ctci.Library.AssortedMethods.SortString(valueToTest);

			return original.Equals(valueToTest);
		}

		// Time: o(n)
		// Space: o(n)
		public static bool CheckPermutation1(string original, string valueToTest)
		{
			if (original.Length != valueToTest.Length) return false;

			var strDict = new Dictionary<char, int>();
			
			foreach (var c in original)
			{
				if (strDict.ContainsKey(c))
				{
					strDict[c]++;
				}
				else
				{
					strDict.Add(c, 1);
				}
			}

			foreach (var c in valueToTest)
			{
				if (strDict.ContainsKey(c))
				{
					strDict[c]--;
					if (strDict[c] < 0)
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}
			return true;
		}
	}
}
