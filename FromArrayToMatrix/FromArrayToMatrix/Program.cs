using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromArrayToMatrix
{
    class Program
    {
        static public Random random = new Random();

        static public int[] GetInitiliazationArrray(int size, int minValue, int maxValue)
        {
            int[] initArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                initArray[i] = random.Next(minValue, maxValue);
            }

            return initArray;
        }

        static public int[,] GetFromVectorToMatrix(int[] vector, int n, int m)
        {

            int[,] matrix = new int[n,m];

            int step = -1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ++step;

                    try
                    {
                        matrix[i, j] = vector[step];
                    }
                    catch
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
         

        }
        static void Main(string[] args)
        {
            Console.Write("Enter of size a array : ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("Enter of minimum value : ");
            int minValue = int.Parse(Console.ReadLine());

            Console.Write("Enter of maximum value : ");
            int maxValue = int.Parse(Console.ReadLine());

            int[] vector = GetInitiliazationArrray(size, minValue, maxValue);

            Console.Write("Enter of rows a array : ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter of columns a array : ");
            int columns = int.Parse(Console.ReadLine());

            foreach(int i in vector)
            {
                Console.Write("{0} ",i);
            }

            Console.WriteLine("\n");

            int[,] matrix = GetFromVectorToMatrix(vector, columns, rows);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ",matrix[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
