using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems.Common;


namespace Tests._01_99._01_19
{
	[TestClass]
	public class Problem03Test
	{
		[TestMethod]
		public void SerializeDeserialize_ShouldReturnSameTree()
		{
			// Arrange
			var node = new Node<string>("root", new Node<string>("left", new Node<string>("left.left"), null), new Node<string>("right"));

			// Act
			var serialized = Problems._01_99._01_19.Problem03.Solution.Serialize(node);
			var deserialized = Problems._01_99._01_19.Problem03.Solution.Deserialize(serialized);

			// Assert
			Assert.AreEqual<string>("left.left", deserialized.Left.Left.Value);
		}
	}
}
