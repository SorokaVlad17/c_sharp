using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFraction
{
    class BL
    {
        public static int CountOfDigits(int number)
        {
            int count = 0;
            do
            {
                count++;
                number /= 10;
            } while (number >= 1);

            return count;

        }

    public static int GetMaxCountOfDigits(int firstNumber, int secondNumber)
        {
            int maxCount ;
            if(firstNumber <= secondNumber)
            {
                maxCount = secondNumber;
            }
            else
            {
                maxCount = firstNumber;
            }

            return maxCount;
        }
    }
}
