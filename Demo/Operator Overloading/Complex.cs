using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }

        #region Operators Overloading
        public static Complex operator +(Complex a, Complex b)
        {

            Complex complex = new Complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),

                Imag = (b?.Imag ?? 0) + (a?.Imag ?? 0)
            };

            return complex;

        }

        //++ IS THE SAME IDEA BUT U HAVE TO MAKE BOTH > AND < 
        #endregion
    }
}
