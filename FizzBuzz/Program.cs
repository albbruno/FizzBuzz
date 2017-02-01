using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputNumOne;
            int inputNumTwo;

            Console.ReadLine();
            FizzBuzz FBObj = new FizzBuzz();

            FBObj.PrintResults();



            
            Console.WriteLine();

            Console.WriteLine("Input two numbers for the next FizzBuzz");

            Console.WriteLine();

            inputNumOne = Convert.ToInt32(Console.ReadLine());
            inputNumTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            FBObj = new FizzBuzz(inputNumOne, inputNumTwo);

            FBObj.PrintResults();

            Console.ReadLine();

        }
    }
}
