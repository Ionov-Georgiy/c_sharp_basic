using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class ClassComplex
    {
        private double im;
        private double re;
        //public ClassComplex Plus(ClassComplex x2)
        //{
        //    ClassComplex x3 = new ClassComplex();
        //    x3.im = x2.im + this.im;
        //    x3.re = x2.re + this.re;
        //    return x3;
        //}

        public ClassComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public ClassComplex Minus(ClassComplex x)
        {
            double im = this.im - x.im;
            double re = this.re - x.re;
            return new ClassComplex(re, im);
        }

        public ClassComplex Multiply(ClassComplex x)
        {
            double im = this.re * x.im + this.im * x.re;
            double re = this.re * x.re - this.im * x.im;
            return new ClassComplex(re, im);
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }

    }
}
