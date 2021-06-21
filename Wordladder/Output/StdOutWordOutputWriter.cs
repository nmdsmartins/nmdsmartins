using System;
using Wordladder.Core;

namespace Wordladder.Output
{
    public sealed class StdOutWordOutputWriter : IWordOutputWriter
    {
        /// <summary>
        /// Builds the word ladder and prints it to the standard output.
        /// </summary>
        /// <param name="endWord"></param>
        public void WriteOutput(Word endWord)
        {
            Console.WriteLine("\n\nFound chain at the {1}th iteration: {0}", string.Join("-", endWord.BuildChain()), endWord.Level);
        }
    }
}