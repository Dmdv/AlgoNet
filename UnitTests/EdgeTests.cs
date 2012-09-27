using AlgorithmsNet.DataStructures.Graphs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class EdgeTests
	{
		[TestMethod]
		public void TestMethod1()
		{
			var edge1 = new Edge<string, int> {Dist = 1, From = "aa", To = "ab"};
			var edge2 = new Edge<string, int> {Dist = 1, From = "aa", To = "ab"};
			var edge3 = new Edge<string, int> {Dist = 1, From = "ab", To = "ab"};

			Assert.IsTrue(edge1.GetHashCode() == edge2.GetHashCode());
			Assert.IsTrue(edge2.GetHashCode() != edge3.GetHashCode());
			Assert.IsTrue(edge1 == edge2);
			Assert.IsTrue(edge1.Equals(edge2));
			Assert.IsTrue(edge1 == edge2);
			Assert.IsTrue(edge1 != edge3);
		}
	}
}