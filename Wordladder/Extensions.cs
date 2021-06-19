using System.Collections.Generic;
using System.Linq;

namespace Wordladder
{
    public static class Extensions
    {
        /// <summary>
        /// Builds a new search based on the input arguments and on the specified dictionary
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static Search ToSearch(this Arguments arguments, IEnumerable<string> dictionary)
        {
            return new Search
            {
                Source = arguments.Start,
                Target = arguments.End,
                Dictionary = dictionary.ToList()
            };
        }
        /// <summary>
        /// Takes the final word and builds a chain by iterating all parents until it reaches the start word. 
        /// </summary>
        /// <param name="winner"></param>
        /// <returns></returns>
        public static string[] BuildChain(this Word winner)
        {
            var chain = new List<string>();
            while (winner.Parent != null)
            {
                chain.Add(winner.Value);

                winner = winner.Parent;
            }

            chain.Add(winner.Value);
            chain.Reverse();

            return chain.ToArray();
        }
    }
}
