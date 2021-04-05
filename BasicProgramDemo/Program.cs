using System;

namespace BasicProgramDemo
{
    class Program
    {
        /// <summary>
        /// Entry point for the console application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value for n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            PrimeFactors.primeFactors(n);
        }
    }
}