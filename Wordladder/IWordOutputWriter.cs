namespace Wordladder
{
    /// <summary>
    /// When implemented handles end word output writing
    /// </summary>
    public interface IWordOutputWriter
    {
        void WriteOutput(Word endWord);
    }
}
