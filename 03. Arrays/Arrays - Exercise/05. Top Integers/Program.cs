﻿using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];

                bool isTopInteger = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nextNum = arr[j];
                    if (nextNum >= currNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                    Console.Write(currNum + " ");
            }
        }
    }
}
