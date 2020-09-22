using System;
using System.Collections.Generic;
using System.Text;

namespace Complex
{
    class Complex
    {
        private int _a { get; set; }
        private int _b { get; set; }

        public Complex(int a,int b)
        {
            _a = a;
            _b = b;
        }

        public override string ToString()
        {
            return string.Format("Дійсне число {0} уявна одиниця {1}", _a, _b);
        }
        public static Complex operator +(Complex x, Complex y)
            => new Complex(x._a + y._a, x._b + y._b);

        public static Complex operator -(Complex x, Complex y)
            => new Complex(x._a - y._a, x._b - y._b);

       public static Complex operator *(Complex x, Complex y)
            => new Complex(x._a * y._a, x._b * y._b);

        public static Complex operator /(Complex x, Complex y)
            => new Complex(x._a / y._a, x._b / y._b);

        public static Complex operator -(Complex x, int y)
            => new Complex(x._a - y, x._b - y);

        public static Complex operator *(int x, Complex y)
            => new Complex(x * y._a, x * y._b);

        public static Complex operator *(Complex x, int a)
        => new Complex(x._a * a, x._b * a);
       



    }
}
