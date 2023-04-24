using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveStringSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //while(true)
            //{
            //    if (input.IndexOf(' ') != -1)
            //        input = input.Remove(input.IndexOf(' '), 1));
            //    else
            //        break;
            //}

            //Console.WriteLine(input);

            List<char> output = new List<char>();
            foreach (char c in input)
            {
            if (c !=' ')
                    output.Add(c);
            }
            Console.WriteLine(output.ToArray());
            

            Console.ReadLine();
        }
    }
}
