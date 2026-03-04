using System;

namespace PracticalWork1
{
    class Program
    {

        delegate bool FilterPredicate(int number);

        static void Main(string[] args)
        {
            Console.WriteLine("=== ЗАВДАННЯ 3: Фiльтрацiя списку ===\n");


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            Console.Write("Парнi числа: ");
            FilterArray(numbers, IsEven);

            Console.Write("Числа бiльше 5: ");
            FilterArray(numbers, IsGreaterThanFive);


            Console.Write("Непарнi числа (лямбда): ");
            FilterArray(numbers, n => n % 2 != 0);

            Console.WriteLine("\nЗавдання 3 виконано! Натиснiть Enter для переходу до завдання 4...");
            Console.ReadLine();
        }


        static void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            foreach (int num in numbers)
            {
                if (predicate(num))
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }


        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        static bool IsGreaterThanFive(int n)
        {
            return n > 5;
        }
    }
}
