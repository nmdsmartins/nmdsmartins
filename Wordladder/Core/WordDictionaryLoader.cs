using System;
using System.IO;
using System.Linq;

namespace Wordladder.Core
{
    /// <summary>
    /// Class responsible for reading a word dictionary from a supplied file path
    /// </summary>
    public class WordDictionaryLoader
    {
        private readonly string _filePath;
        /// <summary>
        /// Creates a new word dictionary reader from the specified path
        /// </summary>
        /// <param name="filePath"></param>
        public WordDictionaryLoader(string filePath)
        {
            _filePath = filePath;
        }
        /// <summary>
        /// Loads an array of strings that are the representation of a word dictionary.
        /// </summary>
        /// <param name="wordLength">The word length limit</param>
        /// <returns>Array of available words</returns>
        public string[] LoadDictionary(int wordLength)
        {
            return new StreamReader(_filePath)
                .ReadToEnd()
                .Split(Environment.NewLine)
                .Where(w => wordLength == 0 || w.Length == wordLength)
                .OrderBy(w => w)
                .ToArray();
        }
    }
}