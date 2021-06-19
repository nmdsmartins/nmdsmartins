using System.Collections.Generic;
using System.IO;

namespace Blueprism
{
    /// <summary>
    /// Handles the creation of the output file
    /// </summary>
    public class OutputFileWriter
    {
        private readonly IEnumerable<string> _wordChain;
        /// <summary>
        /// Creates a new output file writer based on specified the chain of words.
        /// </summary>
        /// <param name="wordChain">Chain of words</param>
        public OutputFileWriter(IEnumerable<string> wordChain)
        {
            _wordChain = wordChain;
        }

        /// <summary>
        /// Writes the chain of words into the path specified file
        /// </summary>
        /// <param name="outputFilePath"></param>
        public void WriteToFile(string outputFilePath)
        {
            using var writer = new StreamWriter(outputFilePath);
            writer.Write(string.Join("-", _wordChain));
            writer.Flush();
            writer.Close();
        }
    }
}
