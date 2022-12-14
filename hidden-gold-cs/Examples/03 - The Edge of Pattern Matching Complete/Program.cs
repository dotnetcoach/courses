using DotNetCoach.CSTricks.B;

List<object> mixOfObjects = new()
{
    true,
    87,
    "Hello World",
    176.0,
    new { X = 42, Y = 87 }
};

ObjectHandler handler = new();

foreach (dynamic o in mixOfObjects)
{
    // Perform distinct handling depending upon the runtime type of o
    handler.Handle(o);
}
