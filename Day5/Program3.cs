using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program3
    {
        static int Method1(int x)
        {
            Console.WriteLine("x={0}", x); //x=100
            x = 5;
            Console.WriteLine("x={0}",x); //x=5
            return x;
        }

        static int Method2(ref int x) //by reference (can be for input or output)
        {
            Console.WriteLine("x={0}", x); //x=100
            x = 5;
            Console.WriteLine("x={0}", x); //x=5
            return x;
        }

        static int Method3(out int x) //by reference for output
        {
            //Console.WriteLine("x={0}", x); //x=100
            x = 5;
            Console.WriteLine("x={0}", x); //x=5
            return x;
        }

        static void Main()
        {
            int number = 100;
            Console.WriteLine("number = {0}", number); //number = 100

            Method1(number);
            Console.WriteLine("number = {0}", number); //number = 100

            number = Method1(number);
            Console.WriteLine("number = {0}", number); //number = 5

            Console.WriteLine("-----Method2-----------");
            number = 100;
            Method2(ref number);
            Console.WriteLine("number = {0}", number); //number = 5

            Console.WriteLine("-----Method3-----------");
            number = 100;
            Method3(out number);
            Console.WriteLine("number = {0}", number); //number = 5
        }
    }
}
