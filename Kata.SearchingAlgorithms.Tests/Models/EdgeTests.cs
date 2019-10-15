using FluentAssertions;
using Kata.SearchingAlgorithms.Models;
using Xunit;

namespace Kata.SearchingAlgorithms.Tests.Models
{
    public class EdgeTests
    {
        [Fact]
        public void Should_be_able_to_assign_node_on_creation()
        {
            var expected = new Node("node");

            var edge = new Edge(expected, 2);

            Node actual = edge.Node;

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Should_be_able_to_assign_cost_on_creation()
        {
            var edge = new Edge(new Node("node"), 1);

            decimal actual = edge.Cost;
            decimal expected = 1m;

            Assert.Equal(expected, actual);
        }
    }
}
