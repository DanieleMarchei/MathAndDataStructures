using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndDataStructures
{
    public class DefaultUndirectedEdge : IEdge
    {
        public double Weight { get; set; }
        public object From { get; set; }
        public object To { get; set; }

        public DefaultUndirectedEdge()
        {
            Weight = 1;
        }

        public bool IsDirected()
        {
            return false;
        }
    }
}
