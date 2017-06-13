using System;

namespace ComplexNumbers_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber numberOne = new ComplexNumber(2, 10);
            ComplexNumber numberTwo = new ComplexNumber(2, 6);
            Console.WriteLine((string)numberOne);
            Console.WriteLine(numberOne == numberTwo);
            //Console.WriteLine(number.ToString(false));

            Console.Read();
        }
    }
}
