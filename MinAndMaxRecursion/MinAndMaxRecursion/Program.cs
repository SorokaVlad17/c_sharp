﻿using System;


namespace MinAndMaxRecursion
{
    class Program
    {
        public static int EnterNumber(ref int count)
        {
            Console.Write("Enter the number : ");
            --count;
            return int.Parse(Console.ReadLine());
        }
        public static int GetMin(int n,int min = int.MaxValue)
        {
            int count = n;
            
            if (count==0)
            {
                return min;
            }

            int number = EnterNumber(ref count);
            
            int otherMin;
            
            if(min<number)
            {
                otherMin = min;
            }
            else
            {
                otherMin = number;
            }

            return GetMin(n - 1, otherMin);
            

        }

        public static int GetMax(int n, int max = int.MinValue)
        {
            int count = n;

            if (count == 0)
            {
                return max;
            }

            int number = EnterNumber(ref count);
            
            int otherMax;
            
            if(max>number)
            {
                otherMax = max;
            }
            else
            {
                otherMax = number;
            }

            return GetMax(n - 1, otherMax);


        }
        static void Main(string[] args)
        {
            Console.Write("Enter the count numbers : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Min = {0}",GetMin(n));

            Console.WriteLine("Max = {0}", GetMax(n));
            
            Console.ReadKey();
        }
    }
}
