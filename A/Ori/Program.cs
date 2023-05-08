internal class Program
{
    unsafe private static void Main(string[] args)
    {
        ConsoleKeyInfo c;
        int x, y;
        int* a;
        Console.Clear();
        Console.WriteLine(Console.WindowHeight);
        Console.WriteLine(Console.WindowWidth);
        Console.CursorVisible = false;
        x = y = 20;
        a = &x;
        Console.WriteLine(x);
        Console.WriteLine(a);

        

        Console.SetCursorPosition(x, y);
        if (false)
        {
            c = Console.ReadKey();
            if (c.Key == ConsoleKey.LeftArrow)
            {
                x--;
            }
            if (c.Key == ConsoleKey.RightArrow)
            {
                x++;
            }
            if (c.Key == ConsoleKey.UpArrow)
            {
                y--;
            }
            if (c.Key == ConsoleKey.DownArrow)
            {
                y++;
            }
            Console.SetCursorPosition(x, y);
            Console.Write("#");
        }
    }
}