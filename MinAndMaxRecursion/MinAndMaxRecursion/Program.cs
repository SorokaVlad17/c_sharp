using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static int Min(int n,int min=int.MaxValue)
        {
            int count = n;
            
            if (count==0)
            {
                return min;
            }

            int number = EnterNumber(ref count);

            int otherMin = min < number ? min : number;

            return Min(n - 1, otherMin);
            

        }

        public static int Max(int n, int max = int.MinValue)
        {
            int count = n;

            if (count == 0)
            {
                return max;
            }

            int number = EnterNumber(ref count);
            int otherMax = max > number ? max : number;

            return Max(n - 1, otherMax);


        }
        static void Main(string[] args)
        {
            Console.Write("Enter the count numbers : ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Min = {0}",Min(n));

            Console.WriteLine("Max = {0}", Max(n));
        }
    }
}
