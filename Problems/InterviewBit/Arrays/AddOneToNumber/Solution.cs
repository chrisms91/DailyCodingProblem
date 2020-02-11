using System;
using System.Collections.Generic;

namespace Problems.InterviewBit.Arrays.AddOneToNumber
{
    public class Solution
    {
        public static List<int> PlusOne(List<int> arr)
        {
            List<int> result = new List<int>();
            int carry = 1;

            for (int reverseIndex = arr.Count - 1; reverseIndex >= 0; reverseIndex--)
            {
                int sum = arr[reverseIndex] + carry;
                carry = sum / 10;
                result.Insert(0, sum % 10);
            }
            result.Insert(0, carry);
            result.RemoveRange(0, result.FindIndex(n => n != 0));
            return result;
        }
    }
}
