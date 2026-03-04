using System;

namespace PracticalWork1
{

    class Logger
    {
        public Action<string> LogHandler;


        public void Log(string message)
        {
            if (LogHandler != null)
            {
                LogHandler(message);
            }
            else
            {
                Console.WriteLine("Немає обробника логування!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ЗАВДАННЯ 5: Логування ===\n");


            Logger logger = new Logger();


            Console.WriteLine("--- Логування в консоль ---");
            logger.LogHandler = Console.WriteLine;
            logger.Log("Звичайне повiдомлення");


            Console.WriteLine("\n--- Логування у верхньому регiстрi ---");
            logger.LogHandler = msg => Console.WriteLine(msg.ToUpper());
            logger.Log("Це повiдомлення буде у верхньому регiстрi");


            Console.WriteLine("\n--- Мультикастинг логування ---");
            logger.LogHandler += msg => Console.WriteLine($"Довжина: {msg.Length}");
            logger.Log("Тестове повiдомлення");


            Console.WriteLine("\n--- Без обробника ---");
            logger.LogHandler = null;
            logger.Log("Це повiдомлення не виведеться");

            Console.WriteLine("\nЗавдання 5 виконано! Натиснiть Enter для переходу до завдання 6...");
            Console.ReadLine();
        }
    }
}
