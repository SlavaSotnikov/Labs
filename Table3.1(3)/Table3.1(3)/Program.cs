using System;

namespace Table3._1_3_
{
    internal class Program
    {
        /// <summary>
        /// Для масиву, що відсортований за зростанням, вивести номер елемента, 
        /// після якого потрібно вставити деяке число y.
        /// </summary>

        static void Main()
        {
            int[] array = { 23,8,16,50,27,61,2 };
            int insert = 20;
            int i;

            Array.Sort(array);

            for (i = 0; i < array.Length - 1; i++)
            {
                if (insert > array[i] && insert < array[i + 1])
                {
                    break;
                }
            }

            Console.WriteLine("Insert after: {0}", i);
            Console.ReadKey();
        }
    }
}
