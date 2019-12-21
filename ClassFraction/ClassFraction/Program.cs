using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(1, 1000);
            Fraction fraction2 = new Fraction(200, 500);
            int maxCount1 = BL.GetMaxCountOfDigits(BL.CountOfDigits(fraction1.GetNumerator()), BL.CountOfDigits(fraction1.GetDenominator()));
            int maxCount2 = BL.GetMaxCountOfDigits(BL.CountOfDigits(fraction2.GetNumerator()), BL.CountOfDigits(fraction2.GetDenominator()));

            #region *

            Fraction rez = fraction1 * fraction2;
            UI.PrintFraction(fraction1, maxCount1);
            Console.Write("*");
            UI.PrintFraction(fraction2, maxCount2);
            int maxCountRez = BL.GetMaxCountOfDigits(BL.CountOfDigits(rez.GetNumerator()), BL.CountOfDigits(rez.GetDenominator()));
            Console.Write("=");
            UI.PrintFraction(rez, maxCountRez);
            Console.CursorLeft += 3;

            #endregion

            #region +

            Fraction rez2 = fraction1 + fraction2;
            UI.PrintFraction(fraction1, maxCount1);
            Console.Write("+");
            UI.PrintFraction(fraction2, maxCount2);
            int maxCountRez2 = BL.GetMaxCountOfDigits(BL.CountOfDigits(rez2.GetNumerator()), BL.CountOfDigits(rez2.GetDenominator()));
            Console.Write("=");
            UI.PrintFraction(rez2, maxCountRez2);
            Console.CursorLeft += 3;

            #endregion

            #region -

            Fraction rez3 = fraction1 - fraction2;
            UI.PrintFraction(fraction1, maxCount1);
            Console.Write("-");
            UI.PrintFraction(fraction2, maxCount2);
            int maxCountRez3 = BL.GetMaxCountOfDigits(BL.CountOfDigits(rez3.GetNumerator()), BL.CountOfDigits(rez3.GetDenominator()));
            Console.Write("=");
            UI.PrintFraction(rez3, maxCountRez3);
            Console.CursorLeft += 3;

            #endregion

            #region /

            Fraction rez4 = fraction1 / fraction2;
            UI.PrintFraction(fraction1, maxCount1);
            Console.Write(":");
            UI.PrintFraction(fraction2, maxCount2);
            int maxCountRez4 = BL.GetMaxCountOfDigits(BL.CountOfDigits(rez4.GetNumerator()), BL.CountOfDigits(rez4.GetDenominator()));
            Console.Write("=");
            UI.PrintFraction(rez4, maxCountRez4);
            Console.CursorLeft += 3;

            #endregion

            Console.ReadKey();
        }
    }
}
