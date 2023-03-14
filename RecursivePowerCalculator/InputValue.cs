using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursivePowerCalculator
{
    public static class InputValue
    {
        private static int _inputValue;

        public static int GetInt()
        {
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (Int32.TryParse(input, out _inputValue))
                    return _inputValue;
                else
                    Console.WriteLine("Please input INTEGER value");
            }
                


        }


    }
}
