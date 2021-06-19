namespace Wordladder
{
    /// <summary>
    /// Handles the provisioning of the word finder.
    /// This class is intended to centralize the creation of the right implementation of a word finder.
    /// </summary>
    public class WordFinderFactory
    {
        /// <summary>
        /// Provides the available word finder.
        /// </summary>
        /// <returns></returns>
        public IWordFinder CreateWordFinder()
        {
            return new RegexWordFinder();
        }
    }
}