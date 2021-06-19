namespace Wordladder
{
    /// <summary>
    /// Handles file word writer
    /// </summary>
    public interface IFileWordOutputWriter : IWordOutputWriter //ISP
    {
        public string OutputFilePath { get; }
    }
}