using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFraction
{
    class Fraction
    {
        #region Private fields

        private int _numerator;
        private int _denominator;

        #endregion

        #region Constructors

        public Fraction(int numenator, int denominator)
        {
            _numerator = numenator;
            _denominator = denominator;
        }

        #endregion

        #region Methods

        public int GetNumerator()
        {
            return _numerator;
        }

        public int GetDenominator()
        {
            return _denominator;
        }

        private Fraction GetCutFraction()
        {
            int divisor = GetBiggestCommonDivisor(_numerator, _denominator);

            return new Fraction(_numerator / divisor, _denominator / divisor);
        }

        private int GetBiggestCommonDivisor(int firstNumber, int secondNumber)
        {
            while (secondNumber != 0)
            {
                int temp = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = temp;
            }

            return firstNumber;
        }

        private static Fraction MultyplieAllFraction(Fraction fr,int multyplier)
        {
            return new Fraction(fr._numerator * multyplier,fr._denominator * multyplier);
        }

        #endregion

        #region Opearators overload

        public static Fraction operator * (Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1._numerator * fr2._numerator, fr1._denominator * fr2._denominator).GetCutFraction();
        }


        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            Fraction rez1 = MultyplieAllFraction(fr1, fr2._denominator);
            Fraction rez2 = MultyplieAllFraction(fr2, fr1._denominator);
            Fraction rez = new Fraction(rez1._numerator + rez2._numerator, rez1._denominator);
            return rez.GetCutFraction();
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            Fraction rez1 = MultyplieAllFraction(fr1, fr2._denominator);
            Fraction rez2 = MultyplieAllFraction(fr2, fr1._denominator);
            Fraction rez = new Fraction(rez1._numerator - rez2._numerator, rez1._denominator);
            return rez.GetCutFraction();
        }

        public static Fraction operator / (Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1._numerator * fr2._denominator, fr1._denominator * fr2._numerator).GetCutFraction();
        }

        #endregion
    }
}
