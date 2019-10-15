using Kata.SearchingAlgorithms.Models;
using System.Collections.Generic;

namespace Kata.SearchingAlgorithms.UseCases
{
    public class UniformCostSearchingKata : SearchingAlgorithmKata
    {
        protected override SearchingAlgorithmResponse Search(Node start, Node target)

        {
            var explored = new List<Node>();

            var pending = new PriorityQueue<Node>();
            pending.Enqueue(start);

            do
            {
                Node current = pending.Dequeue();
                explored.Add(current);

                if (current == target)
                    return CreateResponse(current);

                foreach (Edge edge in current.Edges)
                {
                    Node node = edge.Node;
                    if (explored.Contains(node)) continue;

                    node.Cost += current.Cost + edge.Cost;
                    node.Parent = current;

                    pending.Enqueue(node);
                }
            }
            while (!pending.IsEmpty());

            return default;
        }
    }
}
