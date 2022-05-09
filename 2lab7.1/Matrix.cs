using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab7._1
{
    public class Matrix
    {
        private int N;//row
        private int K;//col
        private int[,] mat;

        public Matrix()
        {
            this.N = 0;
            this.K = 0;
            this.mat = new int[N, K];
        }
        public Matrix(int n, int k)
        {
            if (n > 0 && k > 0)
            {
                this.N = n;
                this.K = k;
                this.mat = new int[K, N];
                for (int i = 0; i < K; i++)
                    for (int j = 0; j < N; j++)
                        mat[i, j] = 0;
            }
        }
        public Matrix(Matrix m)
        {
            this.N = m.N;
            this.K = m.K;
            this.mat = m.mat;
        }
        public static Matrix Create()
        {
            int n = 0;
            int k = 0;
            do
            {
                Console.WriteLine("Please, input number of rows(N):");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please, input number of columns(K):");
                k = Convert.ToInt32(Console.ReadLine());
            } while (!(n > 0 && k > 0));

            return new Matrix(k,n);
        }
        public void Fill()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    Console.Write($"m[{i},{j}] =");
                    this.mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Display()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    Console.Write("{0} ", mat[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.N == b.N && a.K == b.K)
            {
                var matrix = new Matrix(a.N,a.K);
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.K; j++)
                    { matrix.mat[i, j] = a.mat[i, j] + b.mat[i, j]; }
                }
                return matrix;
            }
            else
            {
                Console.WriteLine("Error! matrices must be of the same size!");
                return new Matrix();
            }
        }
        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a.N == b.N && a.K == b.K)
            {
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.K; j++)
                    {
                        if (a.mat[i, j] != b.mat[i, j])
                        { return false; }
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Matrix a, Matrix b)
        {
            if (a.N == b.N && a.K == b.K)
            {
                for (int i = 0; i < a.N; i++)
                {
                    for (int j = 0; j < a.K; j++)
                    {
                        if (a.mat[i, j] != b.mat[i, j])
                        { return true; }
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public double Norm()
        {
            double sum = 0;
            int min = int.MinValue;
            int max = int.MinValue;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    if (mat[i, j] > max)
                    {

                        max = mat[i, j];
                    }
                    if (mat[i, j] < min)
                    {

                        min = mat[i, j];
                    }
                    
                }

            }
            return Math.Abs(max - min);
        }


    }
}


