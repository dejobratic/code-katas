using Kata.Models;
using Kata.SearchingAlgorithms.Exceptions;
using Kata.SearchingAlgorithms.Models;
using Kata.UseCases;
using System.Collections.Generic;
using System.Linq;

namespace Kata.SearchingAlgorithms.UseCases
{
    public abstract class SearchingAlgorithmKata : IKata
    {
        public IKataResponse Execute(IKataRequest kataRequest)
        {
            var request = kataRequest as SearchingAlgorithmRequest;

            SearchingAlgorithmResponse response =
                Search(request.StartNode, request.TargetNode);

            if (response is null)
                throw new UnableToGetSearchingResponseException(request);

            return response;
        }

        protected abstract SearchingAlgorithmResponse Search(Node start, Node target);

        protected static SearchingAlgorithmResponse CreateResponse(Node target)
        {
            IEnumerable<Node> path = GetPath(target);

            return CreateResponse(path);
        }

        protected static SearchingAlgorithmResponse CreateResponse(IEnumerable<Node> path)
        {
            return new SearchingAlgorithmResponse
            {
                Message = string.Join(" -> ", path.Select(node => node.Name))
            };
        }

        protected static IEnumerable<Node> GetPath(Node target)
        {
            var path = new List<Node>();
            for (Node node = target; node != null; node = node.Parent)
                path.Add(node);

            path.Reverse();
            return path;
        }
    }
}
