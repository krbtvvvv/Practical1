using System;

namespace PracticalWork1
{
    class Program
    {

        delegate double MathOperation(double a, double b);

        static void Main(string[] args)
        {
            Console.WriteLine("=== ЗАВДАННЯ 1: Калькулятор ===\n");


            MathOperation operation;


            operation = Add;
            Console.WriteLine($"Add(10, 5) = {operation(10, 5)}");

            operation = Subtract;
            Console.WriteLine($"Subtract(10, 5) = {operation(10, 5)}");

            operation = Multiply;
            Console.WriteLine($"Multiply(10, 5) = {operation(10, 5)}");

            operation = Divide;
            Console.WriteLine($"Divide(10, 5) = {operation(10, 5)}");


        }


        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Помилка: дiлення на нуль!");
                return 0;
            }
            return a / b;
        }
    }
}
