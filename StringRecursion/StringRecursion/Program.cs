using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRecursion
{
    class Program
    {
        public static string StringFunc(string str,int index=0,string strPunctuations="",string strOthrer="")
        {
            
            if(index==str.Length)
            {
                return strPunctuations + strOthrer;
            }
            if(char.IsPunctuation(str[index]))
            {
                strPunctuations += str[index];
            }
            else
            {
                strOthrer += str[index];
            }
            return StringFunc(str, index + 1,strPunctuations,strOthrer);
            
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the line : ");
            string str = Console.ReadLine();

            Console.WriteLine("Result = {0}",StringFunc(str));
        }
    }
}
