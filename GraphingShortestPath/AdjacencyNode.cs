using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphingShortestPath
{
    // Store graph as a simple structure which knows its neigbours
    class AdjacencyNode 
    {
        private int data;
        private LinkedList<AdjacencyNode> neighbours;
    }
}
