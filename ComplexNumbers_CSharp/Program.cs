using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber number = new ComplexNumber(2, 10);
            Console.WriteLine((string)number);
            //Console.WriteLine(number.ToString(false));

            Console.Read();
        }
    }
}
