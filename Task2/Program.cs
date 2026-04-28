namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string logFile = "logPD25.txt";

            MessagePublisher publisher = new MessagePublisher();
            FileLogger logger = new FileLogger(logFile);

            publisher.MessageSent += logger.OnMessageSent;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nType messages (empty line to stop):");

            while (true)
            {
                Console.Write("> ");
                string message = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(message))
                    break;

                publisher.SendMessage(name, message);
            }
        }
    }
}