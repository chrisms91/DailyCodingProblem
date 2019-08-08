using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ctci.Ch01.ArraysandStrings.Q1_09_IsRotation;

namespace Tests.Ctci_Test.Ch01.ArraysandStrings
{
    [TestClass]
    public class Q1_09_IsRotation_Test
    {
        [TestMethod]
        public void IsRotation_ShouldReturnTrue()
        {
            // Assign
            var testSet = new string[] { "waterbottle", "erbottlewat" };
            var testSet1 = new string[] { "lifestyle", "tylelifes" };

            // Act
            var res = Solution.IsRotation(testSet[0], testSet[1]);
            var res1 = Solution.IsRotation(testSet1[0], testSet1[1]);

            // Assert
            Assert.AreEqual(true, res);
            Assert.AreEqual(true, res1);
        }

        [TestMethod]
        public void IsRotation_ShouldReturnFalse()
        {
            // Assign
            var testSet = new string[] { "waterbottle", "erbottlewta" };

            // Act
            var res = Solution.IsRotation(testSet[0], testSet[1]);

            // Assert
            Assert.AreEqual(false, res);
        }
    }
}
