using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndDataStructures
{
    interface IMatrix
    {
        //params allows n-dimentional matrices
        double Get(params int[] index);

        void Set(double value, params int[] index);

        Matrix Plus(Matrix mat);

        Matrix Minus(Matrix mat);

        Matrix Times(Matrix mat);

    }
}
