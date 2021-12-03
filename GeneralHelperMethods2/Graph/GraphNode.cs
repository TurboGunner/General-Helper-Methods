using System.Collections.Generic;
using System.Linq;

namespace GeneralHelperMethods.Graph
{
    public class GraphNode<T>
    {
        public enum NeighborMode { Undirected }
        public T value { get; set; }
        public HashSet<GraphNode<T>> neighbors { get; set; }

        public GraphNode(T v)
        {
            value = v;
            neighbors = new HashSet<GraphNode<T>>();
        }

        public void SetNeighbors(NeighborMode m = NeighborMode.Undirected, params GraphNode<T>[] n)
        {
            if (m.Equals(NeighborMode.Undirected))
            {
                for (int i = 0; i < n.Count(); i++)
                {
                    neighbors.Add(n.ElementAt(i));
                }
            }
        }
        public override bool Equals(object obj)
        {
            if (!(obj is GraphNode<T>))
            {
                return false;
            }
            return value.Equals((obj as GraphNode<T>).value);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"Graph Node Value: {value}";
        }
    }
}
