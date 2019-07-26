using System;
using System.Collections.Generic;
using System.Text;

namespace Ctci.Ch_01._Arrays_and_Strings.Q1_03_URLify
{
	public class Solution
	{

		private static int CountWhiteSpace(char[] input)
		{
			var counter = 0;
			foreach (var c in input)
			{
				if (c == ' ') counter++;
			}
			return counter;
		}

		public static void ReplaceSpaces(char[] input, int length)
		{
			var spaceCount = CountWhiteSpace(input);
			var index = length + spaceCount * 2; // space needed to replace with '%20'

			for (var i = length - 1; i >= 0; i++)
			{
				if (i != ' ')
				{
					input[index] = input[i];
					index--;
				}
				else
				{
					input[index] = '0';
					input[index - 1] = '2';
					input[index - 2] = '%';
					index -= 3;
				}
			}
		}
	}
}
