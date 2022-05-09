using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrix  a:");
            Matrix a = Matrix.Create();
            a.Fill();
            a.Display();

            Console.WriteLine("Matrix  b:");
            Matrix b = Matrix.Create();
            b.Fill();
            b.Display();

            Console.WriteLine("\na + b: ");
            var z = a + b;
            z.Display();
            Console.WriteLine("a == b: {0}", a == b);
            Console.WriteLine("a != b: {0}", a != b);
            Console.WriteLine("\nMatrix norm from matrix a: {0}", a.Norm());
            Console.ReadKey();
        }
    }

}
