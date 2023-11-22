using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class PruebaFizzBuzz
    {
        public void FizzBuzz(int number)
        {
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine($"{i}: {i}");
                    }
                    else if (i % 5 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine($"{i}: FizzBuzz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine($"{i}: Fizz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine($"{i}: Buzz");
                    }
                    else
                    {
                        Console.WriteLine($"{i}: {i}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Tienes que escribir un numero que sea mayor a cero.");
            }
        }
    }
}
