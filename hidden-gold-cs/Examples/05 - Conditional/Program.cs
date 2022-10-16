using System.Diagnostics;

[Conditional("DEBUG")]
static void PrintInfo(string s)
{
    Console.WriteLine($"Debug: {s}");
}

PrintInfo("Start");
Console.WriteLine("Doing stuff...");
PrintInfo("End");
