using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Problems.Random.Arrays.Is_Rotation
{
	public class Solution
	{
		public static bool IsRotation(int[] arrayA, int[] arrayB)
		{
			if (arrayA.Length != arrayB.Length) return false;

			var startingIndex = -1;

			// find starting point of rotated array.
			for (var i = 0; i < arrayB.Length; i++)
			{
				if (arrayA[0] == arrayB[i])
					startingIndex = i;
			}

			if (startingIndex == -1) return false; // there is no matching element => no rotation

			// traverse and compare if they are same.
			for (var i = 0; i < arrayA.Length; i++)
			{
				if (arrayA[i] != arrayB[(startingIndex + i) % arrayB.Length])
					return false;
			}
			return true;
		}

		public static bool IsRotation2(int[] arrayA, int[] arrayB)
		{
			if (arrayA.Length != arrayB.Length) return false;

			var aToStr = string.Join("", arrayA);
			var bToStr = string.Join("", arrayB);

			var concatStrBuilder = new StringBuilder();
			var concatStr = concatStrBuilder.Append(bToStr).Append(bToStr).ToString();

			return concatStr.IndexOf(aToStr, StringComparison.CurrentCultureIgnoreCase) >= 0;
		}
	}
}
