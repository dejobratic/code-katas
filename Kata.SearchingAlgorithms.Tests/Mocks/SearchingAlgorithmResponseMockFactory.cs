using Kata.SearchingAlgorithms.Models;

namespace Kata.SearchingAlgorithms.Tests.Mocks
{
    public static class SearchingAlgorithmResponseMockFactory
    {
        public static SearchingAlgorithmResponse RomaniaCitiesUCS()
        {
            return new SearchingAlgorithmResponse
            {
                Message = "Timisoara -> Arad -> Sibiu -> Rimnicu Vilcea -> Pitesti -> Bucharest"
            };
        }

        public static SearchingAlgorithmResponse RomaniaCitiesBFS()
        {
            return new SearchingAlgorithmResponse
            {
                Message = "Timisoara -> Lugoj -> Mehadia -> Dobreta -> Craiova -> Pitesti -> Bucharest"
            };
        }

        internal static SearchingAlgorithmResponse RomaniaCitiesDFS()
        {
            return new SearchingAlgorithmResponse
            {
                Message = "Timisoara -> Arad -> Zerind -> Oradea -> Sibiu -> Rimnicu Vilcea -> Craiova -> Pitesti -> Bucharest"
            };
        }
    }
}
