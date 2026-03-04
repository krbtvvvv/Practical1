using System;
using System.Collections.Generic;

namespace PracticalWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ЗАВДАННЯ 4: Func та Action ===\n");


            Console.WriteLine("--- Калькулятор з Func ---");
            Func<double, double, double> calc = Add;
            Console.WriteLine($"Add: {calc(10, 5)}");

            calc = Subtract;
            Console.WriteLine($"Subtract: {calc(10, 5)}");

            calc = Multiply;
            Console.WriteLine($"Multiply: {calc(10, 5)}");

            calc = Divide;
            Console.WriteLine($"Divide: {calc(10, 5)}");


            Console.WriteLine("\n--- Фiльтрацiя списку студентiв ---");
            List<string> students = new List<string> {
                "Alice", "Anna", "Bob", "Alex", "Maria", "John", "Andrew", "Kate"
            };


            List<string> studentsWithA = students.FindAll(s => s.StartsWith("A"));
            Console.WriteLine("Студенти на 'A': " + string.Join(", ", studentsWithA));


            List<string> studentsLongName = students.FindAll(s => s.Length > 4);
            Console.WriteLine("Студенти з iменем > 4 символiв: " + string.Join(", ", studentsLongName));


            Console.WriteLine("\n--- Демонстрацiя Action ---");
            Action<string> print = Console.WriteLine;
            print("Це повiдомлення виведене через Action!");

            Console.WriteLine("\nЗавдання 4 виконано! Натиснiть Enter для переходу до завдання 5...");
            Console.ReadLine();
        }


        static double Add(double a, double b) => a + b;
        static double Subtract(double a, double b) => a - b;
        static double Multiply(double a, double b) => a * b;
        static double Divide(double a, double b) => b != 0 ? a / b : 0;
    }
}
