﻿using System;

namespace _2._Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            if (number % 10 == 0)
            {
                sum += 10;
                Console.WriteLine("The number is divisible by 10");
            }
            else if (number % 7 == 0 && sum == 0)
            {
                sum += 7;
                Console.WriteLine("The number is divisible by 7");
            }
            else if (number % 6 == 0 && sum == 0)
            {
                sum += 6;
                Console.WriteLine("The number is divisible by 6");
            }
            else if (number % 3 == 0 && sum == 0)
            {
                sum += 6;
                Console.WriteLine("The number is divisible by 3");
            }
            else if (number % 2 == 0 && sum == 0)
            {
                sum += 6;
                Console.WriteLine("The number is divisible by 2");
            }
            else
                Console.WriteLine("Not divisible");
        }
    }
}
