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
            int[,] arr = new int[2, 4];
            int[,] arr2 = new int[2, 4];
            Console.WriteLine(arr.Equals(arr2)); 
            Console.Read();
        }
    }
}
