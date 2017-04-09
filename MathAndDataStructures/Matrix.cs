using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndDataStructures
{
    public class Matrix : IMatrix
    {
        private readonly uint Rows;
        private readonly uint Columns;

        private double[,] ArrMatrix;

        public uint Dimension => (uint) ArrMatrix.Rank;
        public uint Rank { get { throw new NotImplementedException(""); } }

        public uint[] Dimensions
        {
            get
            {
                uint[] res = { Rows, Columns };
                return res;
            }
        }

        public Matrix(uint Rows, uint Columns)
        {
            this.Rows = Rows;
            this.Columns = Columns;
            ArrMatrix = new double[Rows, Columns];
        }

        public Matrix(double[,] arr)
        {
            this.Rows = (uint)arr.GetLength(0);
            this.Columns = (uint)arr.GetLength(1);
            ArrMatrix = new double[Rows, Columns];
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    ArrMatrix[j, i] = arr[j, i];
                }
            }
        }

        public double Get(params uint[] index)
        {
            if (index.Length != 2)
            {
                throw new ArgumentException("Only 2 numbers for the index must be entered");
            }
            uint r = (uint)index[0];
            uint c = (uint)index[1];
            if (r > Rows || r < 0 || c > Columns || c < 0)
                throw new ArgumentException($"Row must be between 0 and {Rows}, Column must be between 0 and {Columns}");
            return ArrMatrix[r, c];
        }

        public void Set(double value, params uint[] index)
        {
            if (index.Length != 2)
            {
                throw new ArgumentException("Only 2 numbers for the index must be entered");
            }
            uint r = (uint)index[0];
            uint c = (uint)index[1];
            if (r > Rows || r < 0 || c > Columns || c < 0)
                throw new ArgumentException($"Row must be between 0 and {Rows}, Column must be between 0 and {Columns}");
            ArrMatrix[r, c] = value;
        }

        public Matrix Plus(Matrix mat)
        {
            
            if (mat.Rows != Rows || mat.Columns != Columns)
            {
                throw new ArgumentException($"The number of rows and columns of both matrices must be equals");
            }

            Matrix result = new Matrix(Rows, Columns);
            for (uint i = 0; i < Columns; i++)
            {
                for (uint j = 0; j < Rows; j++)
                {
                    result.Set(this.Get(j, i) + mat.Get(j, i), j, i);
                }
            }
            return result;
        }

        public Matrix Minus(Matrix mat)
        {
            if (mat.Rows != Rows || mat.Columns != Columns)
                throw new ArgumentException($"The number of rows and columns of both matrices must be equals");
            Matrix result = new Matrix(Rows, Columns);
            for (uint i = 0; i < Columns; i++)
            {
                for (uint j = 0; j < Rows; j++)
                {
                    result.Set(this.Get(j, i) - mat.Get(j, i), j, i);
                }
            }
            return result;
        }

        public Matrix Times(Matrix mat)
        {
            if (mat.Columns != Rows)
                throw new ArgumentException($"The number of rows must be equal to the number of columns");
            Matrix result = new Matrix(Rows, Columns);
            double tmp = 0;
            for (uint i = 0; i < Columns; i++)
            {
                for (uint j = 0; j < Rows; j++)
                {
                    tmp = 0;
                    for (uint k = 0; k < Columns; k++)
                    {
                        tmp += this.Get(j, k) * mat.Get(k, j);
                    }
                    result.Set(tmp, j, i);
                }
            }
            return result;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Matrix mat = (Matrix)obj;
            bool result = true;

            for (uint i = 0; i < Columns && result; i++)
            {
                for (uint j = 0; j < Rows && result; j++)
                {
                    result &= this.Get(j, i) == mat.Get(j, i);
                }
            }
            return result;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Columns; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    s += ArrMatrix[j, i].ToString() + " ";
                }
                s += "\n";
            }
            return s;
        }
    }
}
