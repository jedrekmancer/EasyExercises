using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePowerCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program returns the power for given exponent of a given number");
            int exponent;
            int baseValue;
            Console.Write("Input base value: ");
            baseValue = InputValue.GetInt();
            Console.Write("Input exponent: ");
            exponent = InputValue.GetInt();

            int result = Power(baseValue, exponent);



            Console.WriteLine("Base value: {0}\nExponent: {1}\nResult: {2}", baseValue, exponent, result);
            Console.ReadLine();
        }

        public static int Power(int baseValue, int exponent)
            {
            if (exponent == 0)
                return 1;
            // else if (exponent > 1)
            // {
                baseValue = baseValue * Power(baseValue, exponent - 1);
            // }
            return baseValue;
                
            }



    }
}
