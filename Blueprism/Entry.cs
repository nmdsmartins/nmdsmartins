using System.Collections.Generic;

namespace Blueprism
{
    public class Entry
    {
        public Entry()
        {
            Ignored = new List<string>();
        }
        /// <summary>
        /// Gets or sets the start or entry word
        /// </summary>
        public Word Word { get; set; }
        /// <summary>
        /// Gets or sets the target word
        /// </summary>
        public string Target { get; set; }
        /// <summary>
        /// Gets or sets the level shared ignored list of words.
        /// </summary>
        public List<string> Ignored { get; set; }
        /// <summary>
        /// Gets or sets the start or entry dictionary
        /// </summary>
        public List<string> Dictionary { get; set; }
    }
}