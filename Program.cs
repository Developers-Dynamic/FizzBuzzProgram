using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzProgram fizzBuzzProgram = new FizzBuzzProgram();
            fizzBuzzProgram.FizzBuzz();
         
            Console.ReadKey();

           
        }
    }
}


class FizzBuzzProgram
{
    public void FizzBuzz()
    {
        Console.WriteLine("FizzBuzz Prgram");

        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);

            }
        }
    }
}