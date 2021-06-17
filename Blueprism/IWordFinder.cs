namespace Blueprism
{
    public interface IWordFinder
    {
        public Word Winner { get; }
        public void Find(Entry entry);
    }
}