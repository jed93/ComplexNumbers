using System;

namespace ComplexNumbers_CSharp
{
    public class ComplexNumber
    {
        // Members of the class
        private double _real;
        private double _imaginary;

        // Properties of the class
        public double Real
        {
            get { return _real; }
            set { _real = value; }
        }

        public double Imaginary
        {
            get { return _imaginary; }
            set { _imaginary = value; }
        }

        // Method overriding
        public override bool Equals(object obj)
        {
            var item = obj as ComplexNumber;

            // Check whether their values are same
            return this._real == item._real && this._imaginary == item._imaginary;
        }

        public override string ToString()
        {
            return String.Format("{0} + {1}i", this._real, this._imaginary);
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
                _real = a._real * b._real - a._imaginary * b._imaginary,
                _imaginary = a._real * b._imaginary + a._imaginary * b._real
            };
        }

        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !a.Equals(b);
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
            return Math.Sqrt(Math.Pow(complexNumber._real, 2) + Math.Pow(complexNumber._imaginary, 2));
        }

        public static implicit operator string(ComplexNumber complexNumber)
        {
            return complexNumber.ToString();
        }
    }
}