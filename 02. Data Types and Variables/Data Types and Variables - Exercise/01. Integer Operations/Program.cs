﻿using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int sumOfFirstAndSecondNumbers = firstNumber + secondNumber;
            int divisionOfTheSum = sumOfFirstAndSecondNumbers / thirdNumber;
            int multiplicationOfTheResult = divisionOfTheSum * fourthNumber;

            Console.WriteLine(multiplicationOfTheResult);
        }
    }
}
