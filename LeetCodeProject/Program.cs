using LeetCodeProject;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Start");
        var s = "PAYPALISHIRING";
        var numRows = 2;
        var output = Zigzag_Conversion.Convert(s, numRows);
        Console.WriteLine(output);
        Console.WriteLine("End");
    }
}