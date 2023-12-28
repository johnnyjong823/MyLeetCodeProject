using LeetCodeProject;
using LeetCodeProject.LeetCodeModel;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Start");
        var s = 1994;
        var output = Integer_to_Roman.IntToRoman(s);
        Console.WriteLine(output);
        Console.WriteLine("End");
    }
}