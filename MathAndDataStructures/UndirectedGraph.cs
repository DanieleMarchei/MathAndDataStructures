using System;
using System.Collections.Generic;
using System.Linq;

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
            if ((double)from == (double)to) throw new ArgumentException("No loop");

            IEdge e = new DefaultUndirectedEdge();
            e.From = from;
            e.To = to;
            Edges.Add(e);
            return e;

        }

        public DrawableGraph Draw()
        {
            throw new NotImplementedException();
        }

        public ISet<IGraph> GetConnectedComponents()
        {
            throw new NotImplementedException();
        }

        public IEdge GetEdge(object from, object to)
        {
            if (!(from is double) || !(to is double)) throw new ArgumentException("Only double accepted");
            if (!Nodes.ContainsKey(from) || !Nodes.ContainsKey(to)) throw new ArgumentException("Node not find");
            IEdge ed;
            try
            {
                ed = Edges.First((IEdge e) => (double)e.From == (double)from && (double)e.To == (double)to || (double)e.From == (double)to && (double)e.To == (double)from);
            }
            catch(Exception ex)
            {
                return null;
            }
            return ed;
        }

        public ISet<IEdge> GetIngoing(object node)
        {
            if (Nodes.ContainsKey(node))
            {
                try
                {
                    IEnumerable<IEdge> en = Edges.Where((IEdge e) => (double)e.From == (double)node || (double)e.To == (double)node);
                    ISet<IEdge> result = new HashSet<IEdge>(en);
                    return result;
                }
                catch (Exception ex)
                {
                    return null;
                }
                
            }
            else
            {
                throw new ArgumentException("Node not found");
            }
        }

        public ISet<IEdge> GetOutgoing(object node)
        {
            return GetIngoing(node);
        }

        public bool IsDirected()
        {
            return false;
        }

        public bool IsReachable(object node)
        {
            throw new NotImplementedException();
        }

        public void SetEdgeWeight(IEdge edge, double weight)
        {
            if (Edges.Contains(edge))
            {
                edge.Weight = weight;
            }
            else
            {
                throw new ArgumentException("Edge not found");
            }
        }

        public void RemoveNode(object node)
        {
            if (Nodes.ContainsKey(node))
            {
                List<IEdge> en = null;
                try
                {
                    en = Edges.Where((IEdge e) => (double)e.From == (double)node || (double)e.To == (double)node).ToList();
                }
                catch(Exception ex)
                {
                    return;
                }
                 
                foreach(IEdge e in en)
                {
                    Edges.Remove(e);
                }
                Nodes.Remove(node);
                uint i = 0;
                List<KeyValuePair<object,uint>> l = Nodes.ToList();
                foreach(KeyValuePair<object,uint> o in l)
                {
                    Nodes[o.Key] = i;
                    i++;
                }
                Id = (uint)Nodes.Count;
            }
            else
            {
                throw new ArgumentException("Node not found");
            }
        }

        public void RemoveEdge(object from, object to)
        {
            IEdge e = GetEdge(from, to);
            Edges.Remove(e);
        }
    }
}
