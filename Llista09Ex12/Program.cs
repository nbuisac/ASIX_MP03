namespace Llista09Ex12;
class Program
{
    static void Main(string[] args)
    {
        string nomFitxer;
        StreamReader f01;
        StreamWriter f02;
        char caracter;

        Console.Write("Entra el nom del fitxer -> ");
        nomFitxer = Console.ReadLine();

        try {
            f01 = new StreamReader(nomFitxer);
            f02 = new StreamWriter(nomFitxer.Trim() + ".UPPER");
            while (! f01.EndOfStream) {
                caracter = (char)f01.Read();
                f02.Write(Char.ToUpper(caracter));
            }
            f01.Close();
            f02.Close();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}
