using System.Collections.Generic;

namespace Blueprism
{
    /// <summary>
    /// Word structure representation with connected child words
    /// </summary>
    public class Word
    {
        /// <summary>
        /// Creates a new word based on the specified value
        /// </summary>
        /// <param name="value">Word value</param>
        public Word(string value) : this()
        {
            Value = value;
        }
        /// <summary>
        /// Creates a new word based on the specified parameters
        /// </summary>
        /// <param name="value">Word value</param>
        /// <param name="level">Word iteration level</param>
        /// <param name="parent">Parent word</param>
        public Word(string value, int level, Word parent) : this(value)
        {
            Level = level;
            Parent = parent;
        }
        /// <summary>
        /// Creates a new word based on another word.
        /// </summary>
        /// <param name="source"></param>
        public Word(Word source):this(source.Value, source.Level, source.Parent)
        {
        }
        /// <summary>
        /// Creates an empty word
        /// </summary>
        public Word() 
        {
            Children = new List<Word>();
        }
        /// <summary>
        /// Gets or sets the iteration level
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// Gets or sets the parent word
        /// </summary>
        public Word Parent { get; set; }
        /// <summary>
        /// Gets or sets the value
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Gets or sets the children words
        /// </summary>
        public List<Word> Children { get; set; }
    }
}