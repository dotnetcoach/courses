using DotNetCoach.CSTricks.B;

List<object> mixOfObjects = new()
{
    true,
    87,
    "Hello World",
    176.0
};

ObjectHandler handler = new();

foreach (object o in mixOfObjects)
{
    // Perform distinct handling depending upon the runtime type of o
    //switch (o)
    //{
    //    case bool b:
    //        handler.Handle(b);
    //        break;
    //    case int i:
    //        handler.Handle(i);
    //        break;
    //    case double d:
    //        handler.Handle(d);
    //        break;
    //    case string s:
    //        handler.Handle(s);
    //        break;
    //    //default:
    //}
}
