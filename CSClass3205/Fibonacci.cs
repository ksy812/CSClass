﻿using System;
using System.Collections.Generic;

namespace CSClass3205
{
    class Fibonacci
    {
        private static Dictionary<int, long> memo = new Dictionary<int, long>();
        public Fibonacci()
        {
        }

        public static long Get(int i)
        {
            Console.Write("Get(" + i + ") 호출 -> ");
            if (i < 0) { return 0; }
            if (i == 1 || i == 2) { return 1; }

            Console.WriteLine();

            if (memo.ContainsKey(i))
            { 
                return memo[i];
            }
            else
            {
                return memo[i] = Get(i - 2) + Get(i - 1);
            }
        }
    }
}