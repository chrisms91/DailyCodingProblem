using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ctci.ctci.Library;
using Ctci.Ch_02._Linked_Lists.Q2_03_Delete_Middle_Node;


namespace Tests.Ctci_Test.Ch02.LinkedLists
{
    [TestClass]
    public class Q2_03_Delete_Middle_Node_Test
    {
        [TestMethod]
        public void DeleteMiddleNode_ShouldRemoveCorrectNode()
        {
            // Assign
            var test = LinkedListNode.CreateLinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            Console.WriteLine(test.LinkedListToString());

            // Act
            Solution.DeleteMiddleNode(test);

            // Assert
            Assert.AreEqual("1 -> 2 -> 4 -> 5 -> 6 -> null", test.LinkedListToString());
        }
    }
}
