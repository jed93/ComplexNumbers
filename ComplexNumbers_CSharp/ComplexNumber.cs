using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers_CSharp
{
    public class ComplexNumber
    {
        // Members of the class
        private double _real;
        private double _imaginary;

        // Get and set methods
        public double GetReal()
        {
            return _real;
        }
        public void SetReal(double real)
        {
            _real = real;
        }
        public double GetImaginary()
        {
            return _imaginary;
        }
        public void SetImaginary(double imaginary)
        {
            _imaginary = imaginary;
        }

        // Operator overloading
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber(a._real + b._real, a._imaginary + b._imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            return new ComplexNumber()
            {
                _real = (a._real * b._real) - (a._imaginary * b._imaginary),
                _imaginary = (a._real * b._imaginary) + (a._imaginary * b._real)
            };
        }

        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            // Check whether their values are same
            return (b._real == a._real && b._imaginary == a._imaginary);
        }

        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !(b._real == a._real && b._imaginary == a._imaginary);
        }

        // Constructors
        public ComplexNumber()
        {
            // Default
            _real = 0;
            _imaginary = 0;
        }

        public ComplexNumber(double firstVal, double secondVal)
        {
            _real = firstVal;
            _imaginary = secondVal;
        }

        // Cast operators
        public static implicit operator double(ComplexNumber complexNumber)
        {
            return Math.Sqrt(Math.Pow(complexNumber.GetReal(), 2) + Math.Pow(complexNumber.GetImaginary(), 2));
        }

        public static implicit operator string(ComplexNumber complexNumber)
        {
            return (System.String.Format("{0} + {1}i", complexNumber.GetReal(), complexNumber.GetImaginary()));
        }
    }
}