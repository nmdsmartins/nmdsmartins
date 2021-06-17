using System.Collections.Generic;

namespace Blueprism
{
    public class Word
    {
        public Word()
        {
            Words = new List<Word>();
        }
        public int Level { get; set; }
        public Word Parent { get; set; }
        public string Source { get; set; }
        public List<Word> Words { get; set; }
    }
}