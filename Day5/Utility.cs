using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Utility
    {
        public static int ReadInteger(string message)
        {
            bool isParsable = false;
            int output;

            do
            {
                Console.Write(message);
                string input = Console.ReadLine();

                isParsable = Int32.TryParse(input, out output);
            } while (isParsable == false);

            return output;
        }

        static void Main()
        {
            int x1 = ReadInteger("Please enter x1: ");
            Console.WriteLine(x1);
            int x2 = ReadInteger("Please enter x2: ");
            Console.WriteLine(x2);
        }
    }
}
