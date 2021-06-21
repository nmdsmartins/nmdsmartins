using Wordladder.Core;

namespace Wordladder.Output
{
    /// <summary>
    /// When implemented handles end word output writing
    /// </summary>
    public interface IWordOutputWriter
    {
        void WriteOutput(Word endWord);
    }
}
