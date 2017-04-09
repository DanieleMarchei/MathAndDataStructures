using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndDataStructures
{
    public interface IGraph
    {
        
        Dictionary<object,uint> Nodes { get; }

        ISet<IEdge> Edges { get; }

        void AddNode(object node);

        IEdge AddEdge(object from, object to);

        void SetEdgeWeight(IEdge edge, double weight);

        IEdge GetEdge(object from, object to);

        void SetNode(object oldNode, object newNode);

        object GetNode(ulong Id);

        ISet<IGraph> GetConnectedComponents();

        bool IsReachable(object node);

        ISet<IEdge> GetOutgoing(object node);

        ISet<IEdge> GetIngoing(object node);

        bool IsDirected();

        

        DrawnGraph Draw();

    }
}
