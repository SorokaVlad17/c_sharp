using System;

namespace Project
{
    class Program
    {
        public int Compare(string a, string b)
        {
            if (a == b)
            {
                return 0;
            }
            else
            {

                if (a.Length == b.Length)
                {

                    int sumaFirstStr = 0, sumaSecondStr = 0;

                    foreach (char i in a.ToCharArray())
                    {
                        sumaFirstStr += (int)i;
                    }

                    foreach (char j in b.ToCharArray())
                    {
                        sumaSecondStr += (int)j;
                    }

                    if (sumaFirstStr < sumaSecondStr)
                    {
                        return -1;
                    }

                    else
                    {
                        return 1;
                    }
                }

                else
                {
                    if(a.Length<b.Length)
                    {
                        return -1;
                    }

                    else
                    {
                        return 1;
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first line : ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second line : ");
            string str2 = Console.ReadLine();

            Console.WriteLine("String.Compare(\"{0}\",\"{1}\") = {2}",str1,str2,string.Compare(str1,str2));

            Console.WriteLine("Program.Compare(\"{0}\",\"{1}\") = {2}", str1, str2, Compare(str1, str2));
        }
    }
}
