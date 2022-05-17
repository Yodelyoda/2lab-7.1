package lab7;
import java.util.Scanner;
public class Program 
{
	public static void main(String[] args)
    {
    	Scanner scan = new Scanner(System.in);
    	System.out.println("Matrix  a:");
        Matrix a = Matrix.Create();
        a.Fill();
        a.Display();

        System.out.println("Matrix  b:");
        Matrix b = Matrix.Create();
        b.Fill();
        b.Display();

        System.out.println("a + b: ");
        var z = Matrix.matrixplus(a,b);
        z.Display();
        System.out.printf("a == b: ", a == b);
        System.out.printf("a != b: ", a != b);
        System.out.printf("Matrix norm from matrix a: ", a.Norm());
       
    }
}
