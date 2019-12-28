using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFraction
{
    class UI
    {
        
        public static void PrintFraction(Fraction fract,int maxCountOfDigits)
        {
            int positionX = Console.CursorLeft;
            int positionY = Console.CursorTop;
            Console.WriteLine(fract.Numerator);
            Console.SetCursorPosition(positionX, positionY + 1);

            for (int i = 0; i < maxCountOfDigits; i++)
            {
                Console.Write("-");
            }
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.WriteLine(fract.Denominarator);
            Console.SetCursorPosition(positionX+maxCountOfDigits, positionY);
        }
    }
}
