namespace append;
class Program
{
    static void Main(string[] args)
    {
        StreamWriter f01;
        
        Console.WriteLine("Afegim en un fitxer!!!");
        f01= new StreamWriter(new FileStream("hola.txt", FileMode.Truncate));
        f01.WriteLine("Hola");
        f01.Close();

    }
}
