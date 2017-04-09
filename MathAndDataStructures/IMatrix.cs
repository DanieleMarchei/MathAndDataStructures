using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndDataStructures
{
    public interface IMatrix
    {
        //params allows n-dimentional matrices
        double Get(params uint[] index);

        void Set(double value, params uint[] index);

        Matrix Plus(Matrix mat);

        Matrix Minus(Matrix mat);

        Matrix Times(Matrix mat);

        uint Rank { get; }

        uint Dimension { get; }

        uint[] Dimensions { get; }
    }
}
