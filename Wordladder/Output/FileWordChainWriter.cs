using System.IO;
using Wordladder.Core;

namespace Wordladder.Output
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class FileWordOutputWriter : IFileWordOutputWriter
    {
        public string OutputFilePath { get; }

        public FileWordOutputWriter(string outputFilePath)
        {
            OutputFilePath = outputFilePath;
        }
        /// <summary>
        /// Builds the word ladder and writes it to a file.
        /// </summary>
        /// <param name="endWord"></param>
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