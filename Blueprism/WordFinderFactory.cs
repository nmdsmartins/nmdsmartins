namespace Blueprism
{
    /// <summary>
    /// Handles the provisioning of the word finder
    /// </summary>
    public class WordFinderFactory
    {
        /// <summary>
        /// Provides the available word finder.
        /// </summary>
        /// <returns></returns>
        public IWordFinder GetWordFinder()
        {
            return new RegexWordFinder();
        }
    }
}