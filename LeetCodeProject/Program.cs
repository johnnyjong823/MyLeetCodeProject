using LeetCodeProject;
using LeetCodeProject.LeetCodeModel;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Start");
        var s = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        var output = Container_With_Most_Water.MaxArea(s);
        Console.WriteLine(output);
        Console.WriteLine("End");
    }
}