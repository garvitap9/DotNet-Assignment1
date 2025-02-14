using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeriesUpto8Elements
{
    public class FibonacciSeriesGeneration
    {
        public int firstNumber = 0;
        public int secondNumber = 1;
        public int nextNumber;
        public int totalElements = 8;

        public void FibonacciSeriesLogic()
        {
            Console.WriteLine("Printing Fibonacci Series upto 8 elements like 1 1 2 3 5 8 13 21 :");
            Console.WriteLine();
            Console.Write($"{secondNumber} ");
            for(int i =1; i<totalElements; ++i)
            {
                nextNumber = firstNumber + secondNumber;
                Console.Write(nextNumber + " ");
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }

    }
}
