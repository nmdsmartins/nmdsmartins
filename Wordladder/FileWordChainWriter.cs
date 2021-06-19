using System.IO;

namespace Wordladder
{
    public sealed class FileWordOutputWriter : IFileWordOutputWriter
    {
        public string OutputFilePath { get; }

        public FileWordOutputWriter(string outputFilePath)
        {
            OutputFilePath = outputFilePath;
        }

        public void WriteOutput(Word endWord)
        {
            using var writer = new StreamWriter(OutputFilePath);
            foreach (var word in endWord.BuildChain())
                writer.WriteLine(word);
            writer.Flush();
            writer.Close();
        }

        
    }
}