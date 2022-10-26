using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table2._4_4_
{
    internal class Program
    {
        /// <summary>
        /// Дано натуральне число. 
        /// Знайти число, утворене з вихідного приписуванням до нього такого самого числа.
        /// </summary>

        static void Main()
        {
            double num = 1;
            double temp = num;
            int factor = 1;

            while (num > 0.9D)
            {
                num /= 10;
                factor *= 10;
            }

            Console.WriteLine(temp * factor + temp);
            Console.ReadKey();
        }
    }
}
