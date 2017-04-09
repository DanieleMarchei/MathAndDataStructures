using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathAndDataStructures.Tests
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void TestMatrixAddOk()
        {
            double[,] mat1 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Matrix matrix1 = new Matrix(mat1);
            double[,] mat2 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Matrix matrix2 = new Matrix(mat2);
            double[,] matresult = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };
            Matrix matrixresult = new Matrix(matresult);
            Assert.AreEqual(matrixresult, matrix1.Plus(matrix2));
        }

        [TestMethod]
        public void TestMatrixAddError()
        {
            double[,] mat1 = { { 1, 1, 1 }, { 1, 1, 3 }, { 1, 1, 1 } };
            Matrix matrix1 = new Matrix(mat1);
            double[,] mat2 = { { 1, 1, 3 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Matrix matrix2 = new Matrix(mat2);
            double[,] matresult = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };
            Matrix matrixresult = new Matrix(matresult);
            Assert.AreNotEqual(matrixresult, matrix1.Plus(matrix2));
        }

        [TestMethod]
        public void TestMatrixSubtractOk()
        {
            double[,] mat1 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Matrix matrix1 = new Matrix(mat1);
            double[,] mat2 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Matrix matrix2 = new Matrix(mat2);
            double[,] matresult = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            Matrix matrixresult = new Matrix(matresult);
            Assert.AreEqual(matrixresult, matrix1.Minus(matrix2));
        }

        [TestMethod]
        public void TestMatrixSubtractError()
        {
            double[,] mat1 = { { 1, 1, 1 }, { 1, 1, 3 }, { 1, 1, 1 } };
            Matrix matrix1 = new Matrix(mat1);
            double[,] mat2 = { { 1, 1, 3 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Matrix matrix2 = new Matrix(mat2);
            double[,] matresult = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            Matrix matrixresult = new Matrix(matresult);
            Assert.AreNotEqual(matrixresult, matrix1.Minus(matrix2));
        }

        [TestMethod]
        public void TestMatrixMultiplyOk()
        {
            double[,] mat1 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Matrix matrix1 = new Matrix(mat1);
            double[,] mat2 = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };
            Matrix matrix2 = new Matrix(mat2);
            double[,] matresult = { { 6, 6, 6}, { 6, 6, 6 }, { 6, 6, 6 } };
            Matrix matrixresult = new Matrix(matresult);
            Assert.AreEqual(matrixresult, matrix1.Times(matrix2));
        }

        [TestMethod]
        public void TestMatrixMultiplyError()
        {
            double[,] mat1 = { { 1, 3, 1 }, { 1, 1, 3 }, { 1, 1, 1 } };
            Matrix matrix1 = new Matrix(mat1);
            double[,] mat2 = { { 2, 2, 2 }, { 2, 3, 2 }, { 2, 2, 2 } };
            Matrix matrix2 = new Matrix(mat2);
            double[,] matresult = { { 6, 6, 6 }, { 6, 6, 6 }, { 6, 6, 6 } };
            Matrix matrixresult = new Matrix(matresult);
            Assert.AreNotEqual(matrixresult, matrix1.Times(matrix2));
        }
    }
}
