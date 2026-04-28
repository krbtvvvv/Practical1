using System.IO;

namespace Task2
{
    internal class FileLogger
    {
        private string filePath;

        public FileLogger(string path)
        {
            filePath = path;
        }

        public void OnMessageSent(object sender, MessageEventArgs e)
        {
            string line = $"[{e.Time}] {e.Sender}: {e.Message}";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(line);
            }
        }
    }
}