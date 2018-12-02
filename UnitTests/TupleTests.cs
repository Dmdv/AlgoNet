using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms.Graphs;
using FluentAssertions;
using Xunit;

namespace UnitTests
{
	public class TupleTests
	{
		[Fact]
		public void TestInitializeGraph()
		{
			var program = new Dijkstra();
			var list = new List<Tuple<string, string, int>>
			{
			    new Tuple<string, string, int>("aa", "bb", 1),
			    new Tuple<string, string, int>("cc", "dd", 2),
			    new Tuple<string, string, int>("aa", "ff", 3),
			    new Tuple<string, string, int>("bb", "aa", 4)
			};

			var verteces = program.InitVerteces(list).OrderBy(x=>x.Value).ToArray();
		
			(verteces.Distinct().Count() == verteces.Length).Should().BeTrue();

		  verteces.Length.Should().Be(5);
		  verteces[0].Value.Should().Be("aa");
		  verteces[1].Value.Should().Be("bb");
		  verteces[2].Value.Should().Be("cc");
		  verteces[3].Value.Should().Be("dd");
		  verteces[4].Value.Should().Be("ff");
		}
	}
}
