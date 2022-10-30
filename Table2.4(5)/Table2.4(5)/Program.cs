using System;
using System.Collections.Generic;

namespace Table2._4_5_
{
    internal class Program
    {
        /// <summary>
        /// Дано число натуральне n. Визначити кількість різних цифр в ньому.
        /// </summary>

        static void Main()
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                int temp = num;
                int length = 0;

                while (temp > 0)
                {
                    temp /= 10;
                    length++;
                }

                int[] array = new int[length];
                int index = 0;

                while (num > 0)
                {
                    array[index++] = num % 10;
                    num /= 10;
                }

                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i; j < array.Length - 1; j++)
                    {
                        if (array[i] == array[j + 1])
                        {
                            length--;
                            break;
                        }
                    }
                }

                Console.WriteLine("Different numbers: {0}", length);
            }
            else
            {
                Console.WriteLine("Wrong value! Try again.");
            }
            
            Console.ReadKey();
        }
    }
}
