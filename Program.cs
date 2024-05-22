using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CodeSmellExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // Code smell: Unused variable
            int unusedVariable = 0;
            
            // Code smell: Long method
            PerformComplexCalculation();

            // Code smell: Magic number
            int result = AddNumbers(5, 10);
            Console.WriteLine("Result: " + result);

            // Code smell: Thread sleep
            Thread.Sleep(5000);

            // Code smell: Redundant array creation
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            PrintNumbers(numbers);
        }

        static void PerformComplexCalculation()
        {
            // Code smell: Long method with no comments
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    Console.Write(i * j);
                }
            }
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        static void PrintNumbers(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
