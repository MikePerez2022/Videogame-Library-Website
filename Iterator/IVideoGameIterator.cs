namespace VideoGameLibrary.Iterator
{
    public interface IVideoGameIterator
    {
        bool HasNext();
        Models.VideoGame Next();
    }
}
