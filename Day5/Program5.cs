using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program5
    {
        static double taxRate=0.07; //declaring a class variable

        static void Main()
        {
            int amount = Utility.ReadInteger("Please enter the purchase amount: ");

            Console.Write("Enter tax rate: ");
            taxRate = Double.Parse(Console.ReadLine());//we're changing the class variable

            double tax = CalculateTax(amount); // <- we're not passing the taxRate here
            Console.WriteLine("Total = {0}", amount + tax);
        }

        static double CalculateTax(double amount)
        {
            return taxRate * amount; //we use class variable and argument
        }
    }
}
