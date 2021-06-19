using System;

namespace Wordladder
{
    public sealed class StdOutWordChainWriter : IWordOutputWriter
    {
        public void WriteOutput(Word endWord)
        {
            Console.WriteLine("\n\nFound chain at the {1}th iteration: {0}", string.Join("-", endWord.BuildChain()), endWord.Level);
        }
    }
}