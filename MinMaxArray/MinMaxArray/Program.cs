using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxArray
{
    class Program
    {

        static public Random random = new Random();

        static public int[] GetInitilizationArray(int size, int minValue, int maxValue)
        {

            int[] initArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                initArray[i] = random.Next(minValue, maxValue);
            }

            return initArray;
        }

        static public int[] GetArrayMinAndMaxReplaced(int[] array, int size)
        {

            int minInArray = int.MaxValue;
            int maxInArray = int.MinValue;
            int positionOfMax = 0,positionOfMin = 0;

            for (int i = 0; i < size; i++)
            {
                if(maxInArray < array[i])
                {
                    maxInArray = array[i];
                    positionOfMax = i;
                }
            }

            for (int i = 0; i < size; i++)
            {
                if (minInArray > array[i])
                {
                    maxInArray = array[i];
                    positionOfMin = i;
                }
            }

            int boof = array[positionOfMin];
            array[positionOfMin] = array[positionOfMax];
            array[positionOfMax] = boof;

            return array;

        }

        static void Main(string[] args)
        {

            Console.Write("Enter of size array : ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("Enter of min value in array : ");
            int minValue = int.Parse(Console.ReadLine());

            Console.Write("Enter of max value in array : ");
            int maxValue = int.Parse(Console.ReadLine());

            int [] array = GetInitilizationArray(size, minValue, maxValue);

            foreach(int i in array)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            array = GetArrayMinAndMaxReplaced(array, size);

            foreach (int i in array)
            {
                Console.Write("{0} ",i);
            }

            Console.ReadKey();

        }
    }
}
