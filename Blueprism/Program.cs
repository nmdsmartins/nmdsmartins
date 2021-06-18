using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Blueprism
{
    class Program
    {
        static void Main(string[] args)
        {
            var arguments = new Arguments(args);
            var start = arguments.Start;
            var end = arguments.End;
            var dictionary = new WordDictionaryReader(arguments.DictionaryPath)
                .LoadDictionary(Settings.MaxLength);

            new ArgumentValidator().Validate(arguments, dictionary);

            var finder = new WordFinderFactory().GetWordFinder();
            var watch = new Stopwatch();

            watch.Start();

            Console.Write($"Searching between «{start}» and «{end}»...");

            var winner = finder.Find(new Search
            {
                Source = start,
                Target = end,
                Dictionary = dictionary.ToList()
            });
            
            if (winner != null)
            {
                var iteration = winner.Level;
                var chain = new List<string>();
                while (winner.Parent != null)
                {
                    chain.Add(winner.Value);

                    winner = winner.Parent;
                }

                chain.Add(winner.Value);
                chain.Reverse();

                Console.WriteLine("\n\nFound chain at the {1}th iteration: {0}", string.Join("-", chain), iteration);
            }
            else
                Console.WriteLine("Sorry but the target word could reached!");

            Console.WriteLine();
            Console.WriteLine($"It tooked {watch.Elapsed} to fulfill the search...");
        }
    }
}
