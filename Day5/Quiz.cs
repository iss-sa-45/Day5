using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Quiz
    {
        static void Main(string[] args)
        {
            int[,] theArray = new int[,]
            {
                    {5,3},
                    {2,9},
                    {2,9},
                    {5,1},
                    {7,1},
                    {8,3},
                    {0,3},
                    {2,2},
                    {9,7}
            };

            int count = 0;

            Console.Write("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());

            //Your code here
            for (int row = 0; row < theArray.GetLength(0); row++)
            {
                for (int col = 0; col < theArray.GetLength(1); col++)
                {
                    int element = theArray[row, col];
                    if (element == input)
                    {
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("There is no {0} in the array.", input);
            }
            else
            {
                Console.WriteLine("The number of {0} is {1}.", input, count);
            }

        }
    }
}
