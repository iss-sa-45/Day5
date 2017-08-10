using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program4
    {
        static void Method1(int[] A)
        {
            Console.WriteLine("A[0] = {0}", A[0]);
            A[0] = 5; //dangerous! it will change the value in the original array.
            Console.WriteLine("A[0] = {0}", A[0]);
        }

        static void Method2(int[] A)
        {
            Console.WriteLine("A[0] = {0}", A[0]);
            A = new int[] { 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("A[0] = {0}", A[0]);
        }

        static void Main()
        {
            int[] X = new int[] { 100, 200, 300, 400, 500 };

            Console.WriteLine("------------Method1----------");
            Console.WriteLine("X[0] = {0}", X[0]); //X[0] = 100
            Method1(X);
            Console.WriteLine("X[0] = {0}", X[0]); //X[0] = 5

            Console.WriteLine("------------Method2----------");
            X = new int[] { 100, 200, 300, 400, 500 };
            Console.WriteLine("X[0] = {0}", X[0]); //X[0] = 100
            Method2(X);
            Console.WriteLine("X[0] = {0}", X[0]); //X[0] = ?

        }
    }
}
