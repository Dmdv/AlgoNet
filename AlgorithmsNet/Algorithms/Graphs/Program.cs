using System;
using System.Collections.Generic;
using System.Linq;
using AlgoNet.Types.Graphs;

namespace AlgoNet.Algorithms.Graphs
{
	public class Dijkstra
	{
		public IEnumerable<string> CheckFuel(string from, string to, IEnumerable<Tuple<string, string, int>> roads)
		{
			var tuples = roads.ToList();

			var src = new Vertex<string>(from) {Dist = 0};
			var dest = new Vertex<string>(to);

			var verteces = InitVerteces(tuples);
			var initVicinity = InitVicinity(tuples);

			return null;
		}

		internal IEnumerable<Vertex<string>> InitVerteces(IEnumerable<Tuple<string, string, int>> roads)
		{
			var edges = roads.ToList();
			return edges
				.Select(x => x.Item1)
				.Union(edges.Select(x => x.Item2))
				.Select(x => new Vertex<string>(x))
				.ToList();
		}

		/// <summary>
		/// Vicinity: key => Edge, Value => edge value.
		/// </summary>
		internal Dictionary<Edge<string, int>, int> InitVicinity(IEnumerable<Tuple<string, string, int>> roads)
		{
			return roads
				.Select(x => new Edge<string, int> {Dist = x.Item3, From = x.Item1, To = x.Item2})
				.ToDictionary(edge => edge, edge => edge.Dist);
		}

		internal void Relax(Vertex<string> from, Vertex<string> to, int dist)
		{
			if (to.Dist > from.Dist + dist)
			{
				to.Dist = from.Dist + dist;
				to.Prev = from;
			}
		}

		static void Main(string[] args)
		{
		}
	}
}
