using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.InterviewBit.Arrays.AddOneToNumber;

namespace Tests.InterviewBitTest.ArraysTest
{
    [TestClass]
    public class AddOneToNumberTest
    {
        [TestMethod]
        public void AddOneToNumber_ShouldReturnRightArray()
        {
            // assign
            var testList = new List<int> { 1, 2, 3 };
            var testList1 = new List<int> { 9, 9, 9 };
            var expected = new List<int> { 1, 2, 4 };
            var expected1 = new List<int> { 1, 0, 0, 0 };

            // act
            var result = Solution.PlusOne(testList);
            var result1 = Solution.PlusOne(testList1);

            // assert
            CollectionAssert.AreEqual(result, expected);
            CollectionAssert.AreEqual(result1, expected1);
        }
    }
}
