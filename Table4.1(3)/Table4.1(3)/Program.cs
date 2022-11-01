using System;

namespace Table4._1_3_
{
    internal class Program
    {
        /// <summary>
        /// Написати функцію, вхідним параметром якої є рядок. 
        /// Функція повинна повертати кількість слів у цьому рядку 
        /// (слова-групи символів, розділені пробілами, або пробілом і початком (кінцем) рядка).
        /// </summary>

        static void Main()
        {
            string source = "In a nut shell";

            int words = GetWordsAmount(source);
            
            Console.WriteLine("Words: {0}", words);
            Console.ReadKey();
        }

        public static int GetWordsAmount(string source)
        {
            int words = 0;
            string temp = string.Empty;

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != ' ')
                {
                    temp += source[i];
                }

                if (source[i] == ' ' || i == source.Length - 1)
                {
                    if (temp.Length > 1)
                    {
                        words++;
                    }

                    temp = string.Empty;
                }
            }

            return words;
        }
    }
}
