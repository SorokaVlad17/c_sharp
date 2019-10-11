using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPolindrom
{
    class Program
    {
        public static bool IsArrayPolindrome(int[] arr)
        {
            bool isPolendrome = false;

            for (int i = 0; i < arr.Length/2; i++)
            {
                if (arr[i] == arr[arr.Length - i - 1])
                {
                    isPolendrome = true;
                }
                else
                {
                    isPolendrome = false;
                    break;
                }
            }

            return isPolendrome;
        }

        static void Main(string[] args)
        {

            Console.Write("Enter numbers separated by spaces:");
            int[] array = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

            if(IsArrayPolindrome(array))
            {

                Console.WriteLine("Array is polindrome!");
            }
            else
            {
                Console.WriteLine("Array is not polindrome!");
            }

            Console.ReadKey();
        }
    }
}
