using System.Collections.Generic;

namespace MathAndDataStructures
{
    /*
     * A class for store a graph with locations on a plane
     */
    public class DrawableGraph
    {
        public ISet<Matrix> Nodes { get; private set; }
        public ISet<IEdge> Edges { get; private set; }

        public DrawableGraph(ISet<Matrix> nodes, ISet<IEdge> edges)
        {
            //matrix must be one dimension
            Nodes = nodes;
            Edges = edges;
        }
    }
}