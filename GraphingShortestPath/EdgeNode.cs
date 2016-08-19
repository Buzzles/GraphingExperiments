using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphingShortestPath
{
    // Adjacency graph with explicit edges.
    class EdgeNode
    {
        private int data;
        private LinkedList<EdgeNode> neighbours; //Edge?
    }

    class Edge
    {
        public EdgeNode StartNode { get; set; }
        public EdgeNode EndNode { get; set; }
    }
}
