using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphingShortestPath
{
    // Adjacency graph with explicit edges.
    class AdjacencyMatrixNode
    {
        private int data;
        private int index;
    }

    class Graph
    {
        List<AdjacencyMatrixNode> nodes;
        bool[][] edges = new bool[10][]; //jagged array
        bool[,] multiEdges = new bool[10, 10]; // true multi dimensional.
    }
}
