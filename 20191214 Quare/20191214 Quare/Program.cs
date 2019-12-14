using System;

namespace _20191214_Quare
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(6);

            q.Enqueue(6);
            q.Enqueue(16);
            q.Enqueue(-6);

            Queue q1 = new Queue(6);
            q1.Enqueue("erer");

            //Console.WriteLine(q.Dequare());

            while (!q.Empty)
            {
                int currentItem = (int)q.Dequeue();

                Console.WriteLine(currentItem);
            }

            Console.ReadKey();
        }
    }
}
