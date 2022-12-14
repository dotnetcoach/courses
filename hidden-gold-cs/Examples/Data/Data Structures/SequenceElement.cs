namespace DotNetCoach.CSTricks.Data.DataStructures;

public class SequenceElement<T>
{
    public T Data { get; set; }
    public SequenceElement<T>? Next { get; set; }

    public SequenceElement(T data)
    {
        Data = data;
    }
}
