﻿using System;

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
            FlipCoin flip = new FlipCoin();
            flip.ReadInput();
            Console.Read();
        }
    }
}