using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndDataStructures
{
    public class UndirectedGraph : IGraph
    {
        private uint Id = 0;

        public Dictionary<object,uint> Nodes { get; private set; }

        public ISet<IEdge> Edges { get; private set; }

        private IMatrix Matrix { get; set; }

        public IMatrix GetMatrix()
        {
            uint dim = (uint)Nodes.Count;
            Matrix = new Matrix(dim, dim);
            double var = 0;
            uint from, to = 0;
            foreach(IEdge e in Edges)
            { 
                from = Nodes[e.From];
                to = Nodes[e.To];
                var = e.Weight;
                Matrix.Set(var, from, to);
                Matrix.Set(var, to, from);
            }
            return Matrix;
        }

        public UndirectedGraph()
        {
            Nodes = new Dictionary<object, uint>();
            Edges = new HashSet<IEdge>();
            Matrix = new Matrix(0,0);
        }

        public void AddNode(object node)
        {
            if (!(node is double)) throw new ArgumentException("Only double accepted");

            Nodes.Add(node,Id);
            Id++;
        }

        public IEdge AddEdge(object from, object to)
        {
            if (!(from is double) || !(to is double)) throw new ArgumentException("Only double accepted");
            if (!Nodes.ContainsKey(from) || !Nodes.ContainsKey(to)) throw new ArgumentException("Node not find");

            IEdge e = new DefaultUndirectedEdge();
            e.From = from;
            e.To = to;
            Edges.Add(e);
            return e;

        }

        public DrawnGraph Draw()
        {
            throw new NotImplementedException();
        }

        public ISet<IGraph> GetConnectedComponents()
        {
            throw new NotImplementedException();
        }

        public IEdge GetEdge(object from, object to)
        {
            throw new NotImplementedException();
        }

        public ISet<IEdge> GetIngoing(object node)
        {
            throw new NotImplementedException();
        }

        public ISet<IEdge> GetOutgoing(object node)
        {
            throw new NotImplementedException();
        }

        public bool IsDirected()
        {
            throw new NotImplementedException();
        }

        public bool IsReachable(object node)
        {
            throw new NotImplementedException();
        }

        public void SetEdgeWeight(IEdge edge, double weight)
        {
            throw new NotImplementedException();
        }

        public void SetNode(object oldNode, object newNode)
        {
            throw new NotImplementedException();
        }

        public object GetNode(ulong Id)
        {
            throw new NotImplementedException();
        }
    }
}
