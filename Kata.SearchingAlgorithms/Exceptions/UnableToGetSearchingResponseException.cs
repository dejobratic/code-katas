using Kata.SearchingAlgorithms.Models;
using System;

namespace Kata.SearchingAlgorithms.Exceptions
{
    public class UnableToGetSearchingResponseException : Exception
    {
        public UnableToGetSearchingResponseException(
            SearchingAlgorithmRequest request) : base(CreateMessage(request))
        {
        }

        private static string CreateMessage(SearchingAlgorithmRequest request)
            => $"Unable to find path between {request.StartNode.Name} and {request.TargetNode.Name}.";
    }
}
