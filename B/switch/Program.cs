internal class Program
{
    private static void Main(string[] args)
    {
        int opcio;
        double v1, v2, res;

        Console.Write("Entra un número");
        v1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Entra un altre número");
        v2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ENTRA UNA OPCIÓ 1, 2, 3, 4");

        opcio = Convert.ToInt32(Console.ReadLine());
    }
}