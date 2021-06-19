using System.Collections.Generic;

namespace Wordladder
{
    /// <summary>
    /// Represents the entry parameters for a word search
    /// </summary>
    public class Search
    {
        /// <summary>
        /// Gets or sets the start or entry word
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// Gets or sets the target word
        /// </summary>
        public string Target { get; set; }
        /// <summary>
        /// Gets or sets the entry dictionary
        /// </summary>
        public List<string> Dictionary { get; set; }
    }
}