using StateSmith.Output.Gil;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Started running...");
        GilHelper.Compile("public class Blah{}", out var a, out var b);
        Console.WriteLine("Finished running.");
    }
}
