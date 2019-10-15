using Kata.SearchingAlgorithms.Models;
using Xunit;

namespace Kata.SearchingAlgorithms.Tests.Models
{
    public class NodeTests
    {
        [Fact]
        public void Should_be_able_to_set_name_on_creation()
        {
            var node = new Node("node");

            Assert.Equal("node", node.Name);
        }

        [Fact]
        public void Should_compare_nodes_based_on_cost()
        {
            var first = new Node("first") { Cost = 1m };
            var second = new Node("second") { Cost = 2m };

            var actual = first.CompareTo(second);
            var expected = first.Cost.CompareTo(second.Cost);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_return_true_when_invoking_equals_on_nodes_with_same_name()
        {
            var first = new Node("first");
            var second = new Node("first");

            Assert.True(first.Equals(second));
        }

        [Fact]
        public void Should_return_false_when_invoking_equals_on_nodes_with_different_names()
        {
            var first = new Node("first");
            var second = new Node("second");

            Assert.False(first.Equals(second));
        }

        [Fact]
        public void Should_return_false_when_invoking_equals_with_a_null_node()
        {
            var first = new Node("first");
            Node second = null;

            Assert.False(first.Equals(second));
        }

        [Fact]
        public void Should_return_true_when_invoking_equal_to_operator_on_nodes_with_same_name()
        {
            var first = new Node("first");
            var second = new Node("first");

            Assert.True(first == second);
        }

        [Fact]
        public void Should_return_false_when_invoking_equal_to_operator_on_nodes_with_different_names()
        {
            var first = new Node("first");
            var second = new Node("second");

            Assert.False(first == second);
        }

        [Fact]
        public void Should_return_false_when_invoking_equal_to_operator_on_nodes_where_one_is_null()
        {
            Node first = null;
            var second = new Node("second");

            Assert.False(first == second);
            Assert.False(second == first);
        }

        [Fact]
        public void Should_return_true_when_invoking_equal_to_operator_on_nodes_where_both_are_null()
        {
            Node first = null;
            Node second = null;

            Assert.True(first == second);
        }

        [Fact]
        public void Should_return_false_when_invoking_not_equal_to_operator_on_nodes_with_same_name()
        {
            var first = new Node("first");
            var second = new Node("first");

            Assert.False(first != second);
        }

        [Fact]
        public void Should_return_true_when_invoking_not_equal_to_operator_on_nodes_with_different_names()
        {
            var first = new Node("first");
            var second = new Node("second");

            Assert.True(first != second);
        }

        [Fact]
        public void Should_return_true_when_invoking_not_equal_to_operator_on_nodes_where_one_is_null()
        {
            Node first = null;
            var second = new Node("second");

            Assert.True(first != second);
            Assert.True(second != first);
        }

        [Fact]
        public void Should_return_false_when_invoking_not_equal_to_operator_on_nodes_where_both_are_null()
        {
            Node first = null;
            Node second = null;

            Assert.False(first != second);
        }
    }
}
