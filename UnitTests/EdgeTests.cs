using Algorithms.Types.Graphs;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
	public class EdgeTests
	{
		[Fact]
		public void TestInitializeEdges()
		{
			var edge1 = new Edge<string, int> {Dist = 1, From = "aa", To = "ab"};
			var edge2 = new Edge<string, int> {Dist = 1, From = "aa", To = "ab"};
			var edge3 = new Edge<string, int> {Dist = 1, From = "ab", To = "ab"};

		  edge1.GetHashCode().Should().Be(edge2.GetHashCode());
		  edge2.GetHashCode().Should().NotBe(edge3.GetHashCode());
		  (edge1 == edge2).Should().BeTrue();
		  edge1.Equals(edge2).Should().BeTrue();
		  (edge1 == edge2).Should().BeTrue();
		  (edge1 != edge3).Should().BeTrue();
		}
	}
}