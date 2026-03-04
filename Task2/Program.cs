using System;

namespace PracticalWork1
{
    class Program
    {

        delegate void NotificationHandler(string message);

        static void Main(string[] args)
        {
            Console.WriteLine("=== ЗАВДАННЯ 2: Мультикастинг ===\n");


            NotificationHandler notifier = SendEmail;
            notifier += SendSMS;


            Console.WriteLine("Викликаємо делегат:");
            notifier("Hello, student!");


            Console.WriteLine("\nВидаляємо SendSMS:");
            notifier -= SendSMS;
            notifier("Тiльки Email");

            Console.WriteLine("\nЗавдання 2 виконано! Натиснiть Enter для переходу до завдання 3...");
            Console.ReadLine();
        }


        static void SendEmail(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }

        static void SendSMS(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}
