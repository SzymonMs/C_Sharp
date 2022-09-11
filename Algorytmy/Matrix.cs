using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytmy
{
    internal class Matrix
    {
        public int n_;
        public int m_;
        public int[,] matrix_;
        public Matrix(int n, int m)
        {
            n_ = n;
            m_ = m;
            matrix_ = new int[n, m];
        }
        public Matrix(int[,] matrix_)
        {
            this.matrix_ = matrix_;
            this.n_ = matrix_.GetLength(0);
            this.m_ = matrix_.GetLength(1);
        }

        public Matrix() { }
        public void FillMatrix()
        {
            int n = n_;
            int m = m_;
            matrix_ = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix_[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public void PrintMatrix()
        {
            int n = n_;
            int m = m_;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix_[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public List<int> GetDiagonal()
        {
            List<int> result = new List<int>();
            int n = n_;
            int m = m_;
            if (n != m)
            {
                throw new Exception("Macierz nie jest kwadratowa, nie ma diagonalnej");
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == j)
                    {
                        result.Add(matrix_[i, j]);
                    }
                }
            }
            return result;
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            int[,] result = new int[a.n_, a.m_];
            if (a.n_ != b.n_ && a.m_ != b.m_)
            {
                throw new Exception("Macierze muszą być takich samych wymiarów");
            }
            if (a.n_ == b.n_ && a.m_ == b.m_)
            {
                for (int i = 0; i < a.n_; i++)
                {
                    for (int j = 0; j < a.m_; j++)
                    {
                        result[i, j] = a.matrix_[i, j] + b.matrix_[i, j];
                    }
                }
            }
            return new Matrix(result);
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            int[,] result = new int[a.n_, b.m_];
            if (a.n_ != b.m_)
            {
                throw new Exception("Macierze nie mają odpowiednich wymiarów");
            }
            for (int k = 0; k < a.n_; k++)
            {
                for (int i = 0; i < b.m_; i++)
                {
                    for (int j = 0; j < a.m_; j++)
                    {
                        result[k, i] += a.matrix_[k, j] * b.matrix_[j, i];
                    }
                }

            }
            return new Matrix(result);
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            int[,] result = new int[a.n_, a.m_];

            if(a.n_ != b.n_ && a.m_ != b.m_)
            {
                throw new Exception("Macierze muszą być takich samych wymiarów");
            }
            if (a.n_ == b.n_ && a.m_ == b.m_)
            {
                for (int i = 0; i < a.n_; i++)
                {
                    for (int j = 0; j < a.m_; j++)
                    {
                        result[i, j] = a.matrix_[i, j] - b.matrix_[i, j];
                    }
                }
            }
            return new Matrix(result);
        }
        public Matrix Ones(int a)
        {
            Matrix matrix = new Matrix(a, a);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    matrix.matrix_[i, j] = 1;
                }
            }
            return matrix;
        }
        public Matrix Zeros(int a)
        {
            Matrix matrix = new Matrix(a, a);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    matrix.matrix_[i, j] = 0;
                }
            }
            return matrix;
        }
        public Matrix Diag(List<int> diag)
        {
            Matrix matrix = new Matrix(diag.Count, diag.Count);
            for (int i = 0; i < matrix.n_; i++)
            {
                for (int j = 0; j < matrix.m_; j++)
                {
                    if (i == j)
                        matrix.matrix_[i, j] = diag[i];
                    else
                        matrix.matrix_[i, j] = 0;
                }
            }
            return matrix;
        }

    }
}
