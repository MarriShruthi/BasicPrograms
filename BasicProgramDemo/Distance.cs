using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramDemo
{
    class Distance
    {
        public static void Length()
        {
            Console.WriteLine("Enter the co-ordinate :");
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X = " + X);
            Console.WriteLine("Y = " + Y);
            Calculate(X, Y);
        }
        public static void Calculate(int x, int y)
        {
            double distance = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine("Euclidean distance = " + distance);
        }
    }
}
