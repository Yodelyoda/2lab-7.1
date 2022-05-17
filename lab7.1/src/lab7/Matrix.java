package lab7;
import java.util.Scanner;
public class Matrix {
	Scanner scan = new Scanner(System.in);
	 private int N;
     private int K;
     private int[] [] mat;

     public Matrix()
     {
         this.N = 0;
         this.K = 0;
         this.mat = new int[N][ K];
     }
     public Matrix(int n, int k)
     {
         if (n > 0 && k > 0)
         {
             this.N = n;
             this.K = k;
             this.mat = new int[K][N];
             for (int i = 0; i < K; i++)
                 for (int j = 0; j < N; j++)
                     mat[i][j] = 0;
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
    	 Scanner scan = new Scanner(System.in);
         int n = 0;
         int k = 0;
         do
         {
        	 System.out.println("Please, input number of rows(N):");
             n = scan.nextInt();
             System.out.println("Please, input number of columns(K):");
             k = scan.nextInt();
         } while (!(n > 0 && k > 0));

         return new Matrix(k,n);
     }
     public void Fill()
     {
    	 Scanner scan = new Scanner(System.in);
         for (int i = 0; i < N; i++)
         {
             for (int j = 0; j < K; j++)
             {
            	 System.out.printf("m[i,j] =");
                 this.mat[i][j] = scan.nextInt();
             }
         }
     }
     public void Display()
     {
         for (int i = 0; i < N; i++)
         {
             for (int j = 0; j < K; j++)
             {
            	 System.out.printf("{0} ", mat[i][j]);
             }
             System.out.println();
         }
     }
     public static Matrix  matrixplus(Matrix a, Matrix b)
     {
         if (a.N == b.N && a.K == b.K)
         {
             var matrix = new Matrix(a.N,a.K);
             for (int i = 0; i < a.N; i++)
             {
                 for (int j = 0; j < a.K; j++)
                 { matrix.mat[i][j] = a.mat[i][j] + b.mat[i][j]; }
             }
             return matrix;
         }
         else
         {
        	 System.out.println("Error! matrices must be of the same size!");
             return new Matrix();
         }
     }
     public static Boolean matrixequal(Matrix a, Matrix b)
     {
         if (a.N == b.N && a.K == b.K)
         {
             for (int i = 0; i < a.N; i++)
             {
                 for (int j = 0; j < a.K; j++)
                 {
                     if (a.mat[i][j] != b.mat[i][j])
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
     public static Boolean matrixnotequal(Matrix a, Matrix b)
     {
         if (a.N == b.N && a.K == b.K)
         {
             for (int i = 0; i < a.N; i++)
             {
                 for (int j = 0; j < a.K; j++)
                 {
                     if (a.mat[i][j] != b.mat[i][j])
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
         int min = 0;
         int max = 0;
      
         for (int i = 0; i < N; i++)
         {
             for (int j = 0; j < K; j++)
             {
                 if (mat[i][j] > max)
                 {

                     max = mat[i][j];
                 }
                 if (mat[i][j] < min)
                 {

                     min = mat[i][j];
                 }
                 
             }
           
         }
         int minmax = max - min;
         return Math.abs(minmax);

     }

}
