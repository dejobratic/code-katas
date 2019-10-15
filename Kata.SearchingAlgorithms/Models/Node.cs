using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Kata.SearchingAlgorithms.Models
{
    public class Node : IEquatable<Node>, IComparable<Node>
    {
        public string Name { get; }
        public decimal Cost { get; set; }
        public Node Parent { get; set; }
        public List<Edge> Edges { get; set; }

        public Node(string name)
        {
            Name = name;
        }

        public int CompareTo([AllowNull] Node other)
        {
            return this.Cost.CompareTo(other.Cost);
        }
        public bool Equals([AllowNull] Node other)
        {
            if (this is null || other is null) return false;

            return this.Name == other.Name;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Node first, Node second)
        {
            if (ReferenceEquals(first, second)) return true;

            if (first is null || second is null) return false;

            return first.Equals(second);
        }

        public static bool operator !=(Node first, Node second)
        {
            return !(first == second);
        }
    }
}
