using System.Collections.Generic;
using Wordladder.Core;

namespace Wordladder.Output
{
    /// <summary>
    /// Handles the creation of the output file
    /// </summary>
    public class OutputWriter
    {
        private readonly Word _endWord;

        /// <summary>
        /// Creates a new output file writer based on specified the end word.
        /// </summary>
        /// <param name="endWord">The end word</param>
        public OutputWriter(Word endWord)
        {
            _endWord = endWord;
        }

        /// <summary>
        /// Writes the chain of words into the path specified file
        /// </summary>
        /// <param name="writers"></param>
        public void WriteOutput(IEnumerable<IWordOutputWriter> writers)
        {
            foreach (var writer in writers)
                writer.WriteOutput(_endWord);
        }
    }
}