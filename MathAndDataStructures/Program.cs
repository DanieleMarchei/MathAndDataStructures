using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            UndirectedGraph ug = new UndirectedGraph();
            ug.AddNode(0.0);
            ug.AddNode(1.0);
            ug.AddNode(2.0);
            ug.AddNode(3.0);
            ug.AddNode(4.0);
            ug.AddNode(5.0);
            ug.AddNode(6.0);
            ug.AddNode(7.0);
            IEdge e = ug.AddEdge(3.0, 1.0);
            ug.AddEdge(0.0, 4.0);
            ug.AddEdge(4.0, 5.0);
            ug.AddEdge(2.0, 1.0);
            ug.AddEdge(6.0, 7.0);
            ug.AddEdge(1.0, 7.0);
            Console.WriteLine(ug.GetMatrix());
            ug.RemoveEdge(0.0,4.0);
            Console.WriteLine(ug.GetMatrix());

            Console.Read();
        }
    }
}
