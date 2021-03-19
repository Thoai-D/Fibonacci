using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for(long i = 0; i < 20; i++)
            {
                Console.WriteLine(LoopingFibonacci(i));
            }
            */

            for(long i = 0; i < 5; i++)
            {
                long fibonacci = RecursiveFibonacci(i);
                string text = string.Format("Fib of {0} is {1}", i, fibonacci);
                Console.WriteLine(text);
            }
            

        }

        static long LoopingFibonacci(long n)
        {
            long firstnumber = 0;
            long secondnumber = 1;
            long result = 0;

            for(long i = 0; i < n; i++)
            {
                firstnumber = secondnumber;
                secondnumber = result;
                result = firstnumber + secondnumber;
            }
            return result;
            
        }

        static int RecursiveFibonacci(long n)
        {
            if(n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return RecursiveFibonacci(n - 2) + RecursiveFibonacci(n - 1);
            }
        }


    }
}
