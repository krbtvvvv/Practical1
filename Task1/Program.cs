namespace Task1
{
    delegate string TextHandler(string inputText);

    internal class Program
    {
        static void Main(string[] args)
        {
            const string sourceFile = "textPD25.txt";
            const string resultFile = "resultPD25.txt";

            ExecuteProcessing(sourceFile, resultFile, ConvertToUpper);
            ExecuteProcessing(sourceFile, resultFile, GetCharCount);
            ExecuteProcessing(sourceFile, resultFile, GetWordCount);
        }

        static void ExecuteProcessing(string inputPath, string outputPath, TextHandler handler)
        {
            var lines = File.ReadAllLines(inputPath);

            using (var fileWriter = new StreamWriter(outputPath, true))
            {
                foreach (string line in lines)
                {
                    fileWriter.WriteLine(handler(line));
                }

                fileWriter.WriteLine("----");
            }
        }

        static string ConvertToUpper(string text)
        {
            return text.ToUpperInvariant();
        }

        static string GetCharCount(string text)
        {
            return $"Chars: {text.Length}";
        }

        static string GetWordCount(string text)
        {
            var words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return $"Words: {words.Length}";
        }
    }
}