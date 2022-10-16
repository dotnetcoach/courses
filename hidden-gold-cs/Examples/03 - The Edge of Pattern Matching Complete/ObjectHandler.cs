namespace DotNetCoach.CSTricks.B;

public class ObjectHandler
{
    public void Handle(bool o)
    {
        Console.WriteLine("Handling bool...\t" + o);
    }
    public void Handle(int o)
    {
        Console.WriteLine("Handling int...\t\t" + o);
    }
    public void Handle(double o)
    {
        Console.WriteLine("Handling double...\t" + o);
    }
    public void Handle(string o)
    {
        Console.WriteLine("Handling string...\t" + o);
    }
    public void Handle(object o)
    {
        Console.WriteLine("Handling object...\t" + o);
    }
}
