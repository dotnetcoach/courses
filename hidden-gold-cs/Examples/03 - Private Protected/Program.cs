var example = new DerivedFromOtherAssembly(87);
//Console.WriteLine(example.X); // Not allowed!

example.Print();

class DerivedFromOtherAssembly
    : DotNetCoach.CSTricks.Data.Library.ClassInOtherAssembly
{
    public DerivedFromOtherAssembly( int x )
    {
        X = x;
    }
}
