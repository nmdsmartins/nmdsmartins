using Wordladder.Input;

namespace Wordladder.Core
{
    /// <summary>
    /// When implemented takes care of finding the end word
    /// </summary>
    public interface IWordFinder
    {
        /// <summary>
        /// Based on the specified search, looks within the containing dictionary for the target word from the contained start word.
        /// </summary>
        /// <param name="search">Entry search parameters</param>
        /// <returns>End or target word</returns>
        public Word Find(Search search);
    }
}