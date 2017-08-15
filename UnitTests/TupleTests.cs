using System;
using System.Collections.Generic;
using System.Linq;
using AlgoNet.Algorithms.Graphs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class TupleTests
	{
		[TestMethod]
		public void TestMethod1()
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
			Assert.IsTrue(verteces.Distinct().Count() == verteces.Count());
			Assert.IsTrue(verteces.Count() == 5);
			Assert.IsTrue(verteces[0].Value == "aa");
			Assert.IsTrue(verteces[1].Value == "bb");
			Assert.IsTrue(verteces[2].Value == "cc");
			Assert.IsTrue(verteces[3].Value == "dd");
			Assert.IsTrue(verteces[4].Value == "ff");
		}
	}
}
