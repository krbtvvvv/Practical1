
using System;

namespace PracticalWork1
{
    class Program
    {

        delegate bool Validator(string input);

        static void Main(string[] args)
        {
            Console.WriteLine("=== ЗАВДАННЯ 6: Динамiчний валiдатор ===\n");


            Validator passwordValidator = GetValidator(8);
            Validator loginValidator = GetValidator(3);


            Console.WriteLine("--- Перевiрка паролiв (мiн. 8 символiв) ---");
            TestValidator(passwordValidator, new string[] {
                "pass1234", "pass", "password123", "1234567", "qwertyui", "abc"
            });

            Console.WriteLine("\n--- Перевiрка логiнiв (мiн. 3 символи) ---");
            TestValidator(loginValidator, new string[] {
                "user123", "ab", "alex", "a", "john_doe", "ok"
            });


            Console.WriteLine("\n--- Введiть своi данi ---");

            Console.Write("Введiть пароль: ");
            string userPassword = Console.ReadLine();
            Console.WriteLine($"Пароль '{userPassword}': {(passwordValidator(userPassword) ? "Валiдний" : "НЕвалiдний (мiнiмум 8 символiв)")}");

            Console.Write("Введiть логiн: ");
            string userLogin = Console.ReadLine();
            Console.WriteLine($"Логiн '{userLogin}': {(loginValidator(userLogin) ? "Валiдний" : "НЕвалiдний (мiнiмум 3 символи)")}");


            Console.WriteLine("\n--- Рiзнi валiдатори ---");
            Validator shortValidator = GetValidator(2);
            Validator longValidator = GetValidator(10);

            string testString = "Hello World";
            Console.WriteLine($"'{testString}' для валiдатора (мін.2): {shortValidator(testString)}");
            Console.WriteLine($"'{testString}' для валiдатора (мін.10): {longValidator(testString)}");

            Console.WriteLine("\nЗавдання 6 виконано!");
            Console.WriteLine("Практична робота №1 завершена! Натиснiть Enter для виходу...");
            Console.ReadLine();
        }


        static Validator GetValidator(int minLength)
        {

            return input => input != null && input.Length >= minLength;
        }


        static void TestValidator(Validator validator, string[] testValues)
        {
            foreach (string value in testValues)
            {
                bool result = validator(value);
                Console.WriteLine($"  '{value}' -> {(result ? "✓" : "✗")}");
            }
        }
    }
}