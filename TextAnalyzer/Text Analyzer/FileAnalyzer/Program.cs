namespace FileAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please enter the path to the file you would like to analyze:");
            string filePath = Console.ReadLine();

            DirectoryInfo directory = new DirectoryInfo(filePath);

            if (directory.Exists is false) 
            {
                Console.WriteLine("Folder Doesn't Exsit");
                return;
            }

            var fileNames = directory.GetFiles();

            IFileAnalysis fileAnalysis;

            foreach (var file in fileNames)
            {
                if (file.IsTxtFile())
                {
                    fileAnalysis = new TxtFileAnalzer();
                    fileAnalysis.AnalyzeFile(file);
                    var results = ((FileAnalyzer)fileAnalysis).GetResults();
                    Console.WriteLine($"File: {file.Name}");
                    Console.WriteLine($"Word Count: {results.WordCount}");
                    Console.WriteLine($"Character Count: {results.CharacterCount}");
                    Console.WriteLine($"Line Count: {results.LineCount}");
                }
                else if (file.IsCsvFile())
                {
                    fileAnalysis = new CSVFileAnalyzer();
                    fileAnalysis.AnalyzeFile(file);
                    var results = ((FileAnalyzer)fileAnalysis).GetResults();
                    Console.WriteLine($"File: {file.Name}");
                    Console.WriteLine($"Field Count: {results.FieldCount}");
                }
                else
                {
                    Console.WriteLine("File type not supported");
                }
            }
        }
    }
}
