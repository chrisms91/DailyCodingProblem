using System;
using System.Collections.Generic;
using System.Text;

namespace Ctci.Ch_01._Arrays_and_Strings.Q1_01_Is_Unique
{
	public class Solution
	{
		// Time: o(n)
		// Space: o(n)
		public static bool IsUnique(string str)
		{
			if (str == null)
			{
				return false;
			}

			var hashSet = new HashSet<char>();

			foreach(var chr in str)
			{
				if (hashSet.Contains(chr))
				{
					return false;
				}
				else
				{
					hashSet.Add(chr);
				}
			}
			return true;
		}
	}
}
