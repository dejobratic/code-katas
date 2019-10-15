using Kata.SearchingAlgorithms.Exceptions;
using Kata.SearchingAlgorithms.Models;
using Kata.SearchingAlgorithms.Tests.Mocks;
using Kata.SearchingAlgorithms.UseCases;
using Kata.UseCases;
using Xunit;

namespace Kata.SearchingAlgorithms.Tests.UseCases
{
    public class UniformCostSearchingKataTests
    {
        [Fact]
        public void Should_be_able_to_execute_kata()
        {
            IKata sut = CreateSut();

            SearchingAlgorithmRequest request =
                SearchingAlgorithmRequestMockFactory.RomaniaCities();

            var actual = sut.Execute(request) as SearchingAlgorithmResponse;

            SearchingAlgorithmResponse expected =
                SearchingAlgorithmResponseMockFactory.RomaniaCitiesUCS();

            Assert.Equal(expected.Message, actual.Message);
        }

        [Fact]
        public void Should_throw_exception_when_kata_cannot_find_result()
        {
            IKata sut = CreateSut();

            SearchingAlgorithmRequest request =
                SearchingAlgorithmRequestMockFactory.RomaniaCitiesUnlinked();

            Assert.Throws<UnableToGetSearchingResponseException>(() => sut.Execute(request));
        }

        private static IKata CreateSut()
        {
            return new UniformCostSearchingKata();
        }
    }
}
