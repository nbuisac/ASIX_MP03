using System.Drawing;
namespace fbin;
class Program
{
    static void Main(string[] args)
    {
        int a = 2;
        double b = 3.15;

        Console.WriteLine($"{a/100d:P}");
        Console.WriteLine($"{a/100d:F}");
        Console.WriteLine(b.ToString("P"));
        Console.WriteLine(b.ToString("F"));
    }
}
