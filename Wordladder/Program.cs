using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Wordladder
{
    class Program
    {
        static void Main(string[] args)
        {
            var arguments = new Arguments(args);
            var start = arguments.Start;
            var end = arguments.End;
            #region SRP
            var dictionary = new WordDictionaryLoader(arguments.DictionaryFilePath) //SRP
                .LoadDictionary(Settings.MaxLength);
            new ArgumentValidator().Validate(arguments, dictionary); //SRP
            #endregion
            #region DIP
            var finder = new WordFinderFactory().CreateWordFinder(); //DIP
            #endregion
            var watch = new Stopwatch();

            watch.Start();

            Console.Write($"Searching between «{start}» and «{end}»...");

            var winner = finder.Find(arguments.ToSearch(dictionary));

            if (winner != null)
            #region OCP
                //OCP
                new OutputWriter(winner)
                    .WriteOutput(CreateWriters(arguments.OutputFilePath));
            #endregion
            else
                Console.WriteLine("Sorry but the target word could reached!");

            Console.WriteLine();
            Console.WriteLine($"It took {watch.Elapsed} to fulfill the search...");
        }

        private static IEnumerable<IWordOutputWriter> CreateWriters(string outputFilePath)
        {
            return new List<IWordOutputWriter>
            {
                new StdOutWordOutputWriter(),
                new FileWordOutputWriter(outputFilePath)
            };
        }
    }
}
