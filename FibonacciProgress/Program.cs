using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciProgress
{
    delegate void PrintPercentage(int n, int i);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series");
            //int limit;
            //Console.Write("Enter Limit");
            //Console Readkey();
            var fibonacci = new Fibonacci(10);
            fibonacci.CalculateFibonacci();
            Console.ReadKey();
        }
    }
    class Fibonacci
    {
        int number = 0;
        PrintPercentage print = new PrintPercentage(CalculatePercentage);
        event PrintPercentage PrintEvent = CalculatePercentage;
        public Fibonacci(int n)
        {
            number = n;
        }
        public async Task CalculateFibonacci()
        {
            for (int i = 0; i <= number; i++) 
            { Console.WriteLine($"{ await nthFibonacci(i)}");
                 //PrintEvent.Invoke(number,i);
                print (number,i);
            }
        }

        public static void CalculatePercentage(int n, int i)
        {
            Console.WriteLine($"{i * 100 / n}%");
        }
        public async Task<int> nthFibonacci(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return await nthFibonacci(n - 1) + await nthFibonacci(n - 2);
        }
    }
}
