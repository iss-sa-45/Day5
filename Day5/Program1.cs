using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program1
    {
        static void Main()
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

            //counting number in array.
            //Input: array, number to count
            //output: count

            //get input from user -> int
            int input = GetInputFromUser();

            //Your code here
            int count = CountElementInArray(theArray, input);

            //write the output to screen
            PrintOutput(count, input);

        }

        static int GetInputFromUser()
        {
            Console.Write("Please enter a number (0-9): ");
            int input = Convert.ToInt32(Console.ReadLine());

            return input;
        }

        static void PrintOutput(int count, int input)
        {
            if (count == 0)
            {
                Console.WriteLine("There is no {0} in the array.", input);
            }
            else
            {
                Console.WriteLine("The number of {0} is {1}.", input, count);
            }
        }

        static int CountElementInArray(int[,] theArray, int input)
        {
            int count = 0;
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

            return count;
        }
    }
}
