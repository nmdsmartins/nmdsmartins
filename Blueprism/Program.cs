using System;
using System.Diagnostics;

namespace Blueprism
{
    class Program
    {
        static void Main(string[] args)
        {
            var arguments = new Arguments(args);
            var start = arguments.Start;
            var end = arguments.End;
            var dictionary = new WordDictionaryReader(arguments.DictionaryFilePath)
                .LoadDictionary(Settings.MaxLength);

            new ArgumentValidator().Validate(arguments, dictionary);

            var finder = new WordFinderFactory().GetWordFinder();
            var watch = new Stopwatch();

            watch.Start();

            Console.Write($"Searching between «{start}» and «{end}»...");

            var winner = finder.Find(arguments.ToSearch(dictionary));
            
            if (winner != null)
            {
                var chain = winner.BuildChain();
                new OutputFileWriter(chain)
                    .WriteToFile(arguments.OutputFilePath);

                Console.WriteLine("\n\nFound chain at the {1}th iteration: {0}", string.Join("-", chain), winner.Level);
            }
            else
                Console.WriteLine("Sorry but the target word could reached!");

            Console.WriteLine();
            Console.WriteLine($"It took {watch.Elapsed} to fulfill the search...");
        }
    }
}
