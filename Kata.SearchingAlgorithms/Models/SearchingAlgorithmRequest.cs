using Kata.Models;

namespace Kata.SearchingAlgorithms.Models
{
    public class SearchingAlgorithmRequest : IKataRequest
    {
        public Node StartNode { get; set; }
        public Node TargetNode { get; set; }
    }
}
