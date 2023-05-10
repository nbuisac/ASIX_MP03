namespace Llista09Ex15;
class Program
{
    static void Main(string[] args)
    {
        const int CLAU = 2;

        string nomFitxer;
        StreamWriter f02;
        StreamReader f01;
        char c;

        Console.Write("Entra el nom del fitxer -> ");
        nomFitxer = Console.ReadLine();
        try {
            f01 = new StreamReader(nomFitxer);
            f02 = new StreamWriter(nomFitxer.Trim() + ".Cesar");
            while (! f01.EndOfStream) {
                // Llegim caràcter
                c = (char) f01.Read();
                // Transformem el caràcter
                if (c >= 'a' && c <= 'z') {
                    c = (char)(((c - 'a' + CLAU) % ('z' - 'a' + 1)) + 'a');
                } else if (c >= 'A' && c <= 'Z') {
                    c = (char)(((c - 'A' + CLAU) % ('Z' - 'A' + 1)) + 'A');
                }

                // Mostrem el caràcter transformat
                f02.Write(c);
            }
            f01.Close();
            f02.Close();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }

    }
}
