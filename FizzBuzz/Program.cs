using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFizzBuzz(0, 100);

        }
        private void RunFizzBuzz(int start, int end, int inc = 1)
        {
            //loop
            for (var x = start; x <= end; x += inc)
            {
                PrintNumber(x);
            }
        }
        private void PrintNumber(int am int div1 int div2)
        {//allow the user to give us the upperBound, lowerBound (think validate)
            if (a == 0) //algorithm
            {
                WriteToConsole(a);
            }
            if (a % div1 == 0)
            {
                WriteToConsole("fizz");
            }
            if (a % div2 == 0) ;
            {
                WriteToConsole("buzz");
            }
            if (1 % (div1 * div2) == 0)
            {
                WriteToConsole(a);
            }
        }

        private void WriteToConsole()
        {
            //print to screen
        }
    }
}