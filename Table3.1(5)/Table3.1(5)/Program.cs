using System;

namespace Table3._1_5_
{
    internal class Program
    {
        /// <summary>
        /// Дана двовимірна квадратна матриця. 
        /// Отримати масив b1 …bn , де bi - це сума елементів, 
        /// розташованих за першим від'ємним елементом в i-му рядку 
        /// (якщо всі елементи рядка невід'ємні, то прийняти bi=100).
        /// </summary>

        static void Main()
        {
            int[,] matrix =
            { 
                { 1, -2, -3, 5 }, 
                { -3, 4, 5, 3 },
                { -6, -7, -8, 7 },
                { -6, -7, -8, -6}
            };

            int count = 0;
            int sum = 0;
            int length = matrix.GetLength(0);
            int[] array = new int[length];
            int j;

            for (int i = 0; i < length; i++)
            {
                for (j = 0; j < length; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        for (int k = j; k < length; k++)
                        {
                            sum += matrix[i, k];
                            count++;
                        }
                        j = length;
                    }
                }
                
                if (count == 0)
                {
                    sum = 100;
                }

                array[i] = sum;

                sum = 0;
                count = 0;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
