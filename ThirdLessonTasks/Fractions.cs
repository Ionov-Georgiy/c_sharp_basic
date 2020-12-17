using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class Fractions
    {
        int integer = 0;
        int numerator = 1;
        int denominator = 1;

        public Fractions(int numerator, int denominator)
        {
            CheckArgOnZeroValue(denominator);
            this.numerator = numerator;
            this.denominator = denominator;
            this.Cut();
        }

        public Fractions(int integer, int numerator, int denominator)
        {
            CheckArgOnZeroValue(denominator);
            this.integer = integer;
            this.numerator = numerator;
            this.denominator = denominator;
            this.Cut();
        }

        public Fractions(int integer)
        {
            this.integer = integer - 1;
        }

        public Fractions Plus(Fractions x)
        {
            this.toOrdinaryFraction();
            x.toOrdinaryFraction();
            int numerator1 = this.numerator * x.denominator;
            int numenator2 = x.numerator * this.denominator;
            int denomenator = this.denominator * x.denominator;
            return new Fractions(numerator1 + numenator2, denomenator);
        }

        public Fractions Minus(Fractions x)
        {
            this.toOrdinaryFraction();
            x.toOrdinaryFraction();
            int numerator = this.numerator * x.denominator - x.numerator * this.denominator;
            int denomenator = this.denominator * x.denominator;
            return new Fractions(numerator, denomenator);
        }

        public Fractions Multiply(Fractions x)
        {
            this.toOrdinaryFraction();
            x.toOrdinaryFraction();
            int numerator = this.numerator * x.numerator;
            int denomenator = this.denominator * x.denominator;
            return new Fractions(numerator, denomenator);
        }

        public Fractions Divide(Fractions x)
        {
            this.toOrdinaryFraction();
            x.toOrdinaryFraction();
            int numerator = this.numerator * x.denominator;
            int denomenator = this.denominator * x.numerator;
            return new Fractions(numerator, denomenator);
        }

        private void toOrdinaryFraction()
        {
            if (this.integer != 0)
            {
                int numerator = this.integer * this.denominator + this.numerator;
                this.numerator = numerator;
                this.integer = 0;
            }
        }

        public void Cut()
        {
            while (this.numerator % 2 == 0 && this.denominator % 2 == 0)
            {
                this.toOrdinaryFraction();
                this.numerator = this.numerator / 2;
                this.denominator = this.denominator / 2;
            }
            this.numeratorToInteger();
        }

        private void numeratorToInteger()
        {
            while (this.numerator > this.denominator)
            {
                ++this.integer;
                this.numerator = this.numerator - this.denominator;
            }
        }

        private void CheckArgOnZeroValue(int arg)
        {
            if (arg == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
        }
        public string ToString()
        {
            if (this.integer > 0)
            {
                return this.integer + "[" + this.numerator.ToString() + "|" + this.denominator.ToString() + "]";
            }
            return this.numerator.ToString() + "|" + this.denominator.ToString();
        }
    }
}
