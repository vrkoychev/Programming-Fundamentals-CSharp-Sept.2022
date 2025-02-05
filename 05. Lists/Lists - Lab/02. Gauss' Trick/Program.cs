﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = 
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < nums.Count / 2; i++)
            {
                int currSum = nums[i] + nums[nums.Count - 1 - i];

                result.Add(currSum);
            }

            if (nums.Count % 2 != 0)
            {
                result.Add(nums[nums.Count / 2]);
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
