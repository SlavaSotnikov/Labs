using System;
using System.Collections.Generic;

namespace Table2._4
{
    internal class Program
    {
        /// <summary>
        /// Дано натуральне число. Визначити, чи однакові в ньому цифри.
        /// </summary>

        static void Main()
        {
            Console.Write("Enter a number: ");
            
            if (decimal.TryParse(Console.ReadLine(), out decimal initNumber))
            {
                decimal fraction = initNumber / 10;
                decimal rest = 0;
                bool result = true;
                var ints = new List<int>();

                do
                {
                    rest = (fraction - (int)fraction) * 10;
                    ints.Add((int)rest);
                    decimal r = fraction;
                    fraction = (int)r;
                    fraction /= 10;

                } while (fraction > 0);

                for (int i = 0; i < ints.Count - 1; i++)
                {
                    if (ints[i] != ints[i + 1])
                    {
                        result = false;
                        break;
                    }
                }

                Console.WriteLine($"Similar: {result}");
            }
            else
            {
                Console.WriteLine("Wrong value! Try again.");
            }
            
            Console.ReadKey();
        }
    }
}
