using System;
using System.Collections.Generic;
using System.Text;

namespace BasicProgramDemo
{
    class LeapYear
    {
        public void ReadInput()
        {
            Console.WriteLine("Enter a 4 digit year :");
            int year = Convert.ToInt32(Console.ReadLine());
            Leap(year);
        }
        public static void Leap(int year)
        {
            if (year % 4 == 0)
                Console.WriteLine(+year + " is a Leap Year");
            else
                Console.WriteLine(+year + " is Not a Leap Year");
        }
    }
}
