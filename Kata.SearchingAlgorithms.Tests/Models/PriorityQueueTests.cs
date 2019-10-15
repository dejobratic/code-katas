using Kata.SearchingAlgorithms.Models;
using System;
using Xunit;

namespace Kata.SearchingAlgorithms.Tests.Models
{
    public class PriorityQueueTests
    {
        [Fact]
        public void Should_be_empty_when_created()
        {
            var sut = new PriorityQueue<int>();

            Assert.Empty(sut);
        }

        [Fact]
        public void Should_be_able_to_add_element()
        {
            var sut = new PriorityQueue<int>();
            sut.Enqueue(1);

            Assert.Single(sut);
        }

        [Fact]
        public void Should_be_able_to_add_elements_in_priority_order()
        {
            var sut = new PriorityQueue<int>();
            sut.Enqueue(2);
            sut.Enqueue(1);
            sut.Enqueue(3);
            sut.Enqueue(0);
            sut.Enqueue(1);

            Assert.Equal(0, sut.Dequeue());
            Assert.Equal(1, sut.Dequeue());
            Assert.Equal(1, sut.Dequeue());
            Assert.Equal(2, sut.Dequeue());
            Assert.Equal(3, sut.Dequeue());
        }

        [Fact]
        public void Should_throw_exception_when_dequeuing_from_empty_queue()
        {
            var sut = new PriorityQueue<int>();
            Assert.Throws<InvalidOperationException>(() => sut.Dequeue());
        }

        [Fact]
        public void Should_return_false_when_queue_is_not_empty()
        {
            var sut = new PriorityQueue<int>();
            sut.Enqueue(1);

            Assert.False(sut.IsEmpty());
        }

        [Fact]
        public void Should_return_true_when_queue_is_empty()
        {
            var sut = new PriorityQueue<int>();

            Assert.True(sut.IsEmpty());
        }
    }
}
