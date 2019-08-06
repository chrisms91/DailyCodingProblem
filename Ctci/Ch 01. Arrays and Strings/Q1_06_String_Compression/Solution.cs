using System;
using System.Collections.Generic;
using System.Text;

namespace Ctci.Ch_01._Arrays_and_Strings.Q1_06_String_Compression
{
	public class Solution
	{
		// Time: O(n)
		// Space: O(n)
		public static string StringCompression(string str)
		{
			str = str.ToLower();
			var pointerA = str.Length - 1;
			var pointerB = pointerA;
			var sb = new StringBuilder();
			var counter = 1;

			while(pointerA > 0)
			{
				if (str[pointerA - 1] == str[pointerB])
				{
					counter++;
					pointerA -= 1;
				}
				else
				{
					pointerA -= 1;
					sb.Insert(0, counter);
					sb.Insert(0, str[pointerB]);
					pointerB = pointerA;
					counter = 1;
				}
			}
			sb.Insert(0, counter);
			sb.Insert(0, str[pointerB]);

			var compressed = sb.ToString();
			return str.Length < compressed.Length ? str : compressed;
		}
	}
}
