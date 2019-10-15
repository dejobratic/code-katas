namespace Kata.SearchingAlgorithms.Models
{
    public class Edge
    {
        public Node Node { get; }
        public decimal Cost { get; }

        public Edge(Node node, decimal cost)
        {
            Node = node;
            Cost = cost;
        }
    }
}
