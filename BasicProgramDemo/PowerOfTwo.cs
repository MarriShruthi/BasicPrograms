using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramDemo
{
    class PowerOfTwo
    {
        public void ReadInput()
        {
            Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Power(n);
        }
        public static void Power(int n)
        {
            for(int i=0; i<=n; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine("2 ^ "+i +" = " + result);
            }
        }
    }
}
