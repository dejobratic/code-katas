using Kata.SearchingAlgorithms.Models;
using System.Collections.Generic;

namespace Kata.SearchingAlgorithms.UseCases
{
    public class BreadthFirstSearchingKata : SearchingAlgorithmKata
    {
        protected override SearchingAlgorithmResponse Search(Node start, Node target)
        {
            var explored = new List<Node>();

            var pending = new List<Node> { start };

            do
            {
                Node current = pending[0];
                pending.RemoveAt(0);

                if (current == target)
                    return CreateResponse(current);

                explored.Add(current);

                foreach (Edge edge in current.Edges)
                {
                    Node node = edge.Node;
                    if (explored.Contains(node)) continue;

                    node.Parent = current;

                    pending.Add(node);
                }
            }
            while (pending.Count > 0);

            return default;
        }
    }
}
