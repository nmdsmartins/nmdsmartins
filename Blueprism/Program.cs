using System;
using System.Linq;

namespace Blueprism
{
    class Program
    {
        private static string[] _words = {
            "yore", "wire", "tore", "tire", "sure", "star", "sort", "sore", "sorb", "sole", "size", "sire", "side",
            "more", "mire", "lore", "iore", "hire", "hike", "gore", "fire", "dire", "core", "bore"
        };

        static void Main(string[] args)
        {
            var start = "hide";
            var end = "sort";
            var dictionary = _words.OrderBy(w => w);
            var word = new Word { Level = 0, Source = start };
            var finder = new RegexWordFinder();
            
            finder.Find(new Entry
            {
                Word = word,
                Target = end,
                Dictionary = dictionary.ToList()
            });

            var winner = finder.Winner;
            if(winner != null)
            {
                var chain = new string[winner.Level + 1];

                chain[0] = start;

                while (winner.Parent != null)
                {
                    chain[winner.Level] = winner.Source;

                    winner = winner.Parent;
                }

                Console.WriteLine(string.Join("-", chain));
            }
            else
                Console.WriteLine("Sorry but the target word could reached!");
        }
    }
}
