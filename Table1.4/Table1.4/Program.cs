using System;

namespace Table1._4
{
    internal class Program
    {
        /// <summary>
        /// Почавши тренування, лижник у перший день пробіг 10 км.
        /// Кожний наступний день він збільшував пробіг на 10% від пробігу попереднього дня. 
        /// Визначити:
        ///     а) пробіг лижника за другий, третій, ..., десятий день тренувань;
        ///     б) який сумарній путь він пробіг за перші 7 днів тренувань.
        /// </summary>


        static void Main()
        {
            double distance = 10;
            double percent = 10D / 100D;
            double sum = distance;

            Console.Write("Please enter amount of days: ");
            string fromConsole = Console.ReadLine();
            if (int.TryParse(fromConsole, out int days) && days > 0)
            {
                for (int i = 0; i < days - 1; i++)
                {
                    distance += distance * percent;
                    sum += distance;
                }

                Console.WriteLine();
                Console.WriteLine($"{days} days' distance is: {distance} km");
                Console.WriteLine($"  Total distance is: {sum} km");
            }
            else
            {
                Console.WriteLine("Incorrect value! Please try again.");
            }
            
            Console.ReadKey();
        }
    }
}
