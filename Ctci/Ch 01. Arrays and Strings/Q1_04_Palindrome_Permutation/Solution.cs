using System;
using System.Collections.Generic;
using System.Text;

namespace Ctci.Ch_01._Arrays_and_Strings.Q1_04_Palindrome_Permutation
{
	public class Solution
	{
		public static bool IsPermutationOfPalindrome(string str)
		{
			var dict = new Dictionary<char, int>();
			var lowerStr = str.ToLower();
			// map chars in dictionary, ignore whitespace
			foreach (char c in lowerStr)
			{
				if (!Char.IsWhiteSpace(c))
				{
					if (dict.ContainsKey(c))
					{
						dict[c]++;
					}
					else
					{
						dict.Add(c, 1);
					}
				}
			}

			// check if there is at most one odd value
			var foundOdd = false;
			foreach (var val in dict.Values)
			{
				if (val % 2 == 1)
				{
					if (foundOdd)
					{
						return false;
					}
					foundOdd = true;
				}
			}

			return true;
		}
	}
}
