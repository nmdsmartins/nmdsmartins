using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Blueprism
{
    public sealed class RegexWordFinder : IWordFinder
    {
        public Word Winner { get; private set; }
        public void Find(Entry entry)
        {
            var word = entry.Word;

            //Exit condition
            if (word.Source == entry.Target)
                Winner = word;
            
            var @checked = new List<string>();

            for (var i = 0; i < word.Source.Length; i++)
            {
                var chars = word.Source.ToCharArray();
                chars[i] = '.';
                var pattern = new string(chars);
                var found = entry.Dictionary.Except(entry.Ignored).Where(w => Regex.Match(w, pattern).Success);
                if (found.Any())
                {
                    //add the word as checked
                    @checked.AddRange(found);
                    //add word to the level shared words
                    entry.Ignored.AddRange(found);
                }
            }

            word.Words.AddRange(@checked.Select(f => new Word
            {
                Level = word.Level + 1,
                Source = f,
                Parent = word
            }));

            foreach (var childWord in word.Words)
            {
                Find(new Entry
                {
                    Word = childWord,
                    Target = entry.Target,
                    Ignored = entry.Ignored,
                    Dictionary = entry.Dictionary.Except(@checked).ToList()
                });
            }
        }
    }
}