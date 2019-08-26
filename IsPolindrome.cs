using System;

namespace Project
{
    class Program
    {
       public static string IsPolindrome(string a)
       {

            for (int i = 0; i < a.Length / 2; i++)
            {
                    if (a[i] == a[a.Length - i - 1])
                    {
                        continue;
                    }
                    else
                    {
                        return string.Format("{0} is not polindrome", a);
                    }
            }

            return string.Format("{0} is polindrome", a);
       }
       
        static void Main(string[] args)
        {

            Console.Write("Enter line: ");
            string str = Console.ReadLine();

            Console.WriteLine(IsPolindrome(str));

        }
    }
}
