﻿using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split().
                Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split().
                Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool areIdentical = false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    areIdentical = true;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    sum += arr1[i];
                }
            }

            if (areIdentical == false)
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
