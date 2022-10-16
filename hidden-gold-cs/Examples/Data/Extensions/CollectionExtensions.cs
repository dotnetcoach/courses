namespace DotNetCoach.CSTricks.Data.Extensions;

public static class CollectionExtensions
{
    public static void Add<T>(this Queue<T> queue, T t)
    {
        queue.Enqueue(t);
    }
}
