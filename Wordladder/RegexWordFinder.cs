using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Wordladder
{
    /// <summary>
    /// Represents a word finder based on regular expressions
    /// </summary>
    public class RegexWordFinder : IWordFinder
    {
        /// <summary>
        /// Based on the specified search, looks within the containing dictionary for the target word from the contained start word.
        /// </summary>
        /// <param name="search">Entry search parameters</param>
        /// <returns>End or target word</returns>
        public Word Find(Search search)
        {
            var words = new List<Word> { new Word(search.Source) };
            var ignored = new List<string> { search.Source };

            var iteration = 1;
            for (var i = 0; i < ignored.Count; i++)
            {
                for (var c = 0; c < search.Source.Length; c++)
                {
                    var chars = ignored[i]
                        .ToCharArray();
                    chars[c] = '.';
                    var pattern = new string(chars);

                    foreach (var match in search.Dictionary
                        .Except(ignored)// Get rid of the already found matches
                        .Where(w => Regex.Match(w, pattern, RegexOptions.IgnoreCase).Success))
                    {
                        words.Add(new Word(match, iteration, words.Find(w => w.Value == ignored[i])));
                        
                        if (match == search.Target) 
                            return words.Last(); //We did it, we found the target word
                        
                        ignored.Add(match);
                    }
                }

                iteration++;
            }

            return null;
        }
    }
}