using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static int Factorial(int number)
        {
            
            if(number==0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
