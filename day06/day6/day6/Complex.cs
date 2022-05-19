using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6
{
    class Complex
    {
        int real;
        int imag;
        public Complex()
        {

        }
        public Complex(int real, int imag)
        {
            this.real = real;
            this.imag = imag;
        }
       
        public int Real { get { return real; }  set { real = value; }  }
        public int Imag { get { return imag; } set { imag = value; } }

        public override string ToString()
        {
            return $"{real}+{imag}i";
        }

        public static Complex operator +(Complex L,Complex R)
        {
            Complex res = new Complex();
            res.real = L.real + R.real;
            res.imag = L.imag + R.imag;
            return res;
        }

        public static Complex operator +(Complex L, int R)
        {
            Complex res = new Complex();
            res.real = L.real + R;
            res.imag = L.imag;
            return res;
        }

        public static Complex operator ++(Complex L)
        {
            Complex res = new Complex();
            res.real = L.real + 1;
            res.imag = L.imag;
            return res;
        }

        public static Boolean operator >(Complex L,Complex R)
        {
            if (L.real == R.real)
                return L.imag > R.imag;
            else
                return L.real > R.real;
        }

        public static Boolean operator <(Complex L, Complex R)
        {
            return !(L > R);
        }



    }
}
