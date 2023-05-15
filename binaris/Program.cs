namespace binaris;
class Program
{
    static void Main(string[] args)
    {
        BinaryWriter fitxerW;
        int i;
        Console.WriteLine("Generem i escrivim");
        fitxerW = new BinaryWriter(File.OpenWrite("prova.dat"));
        for(i = 0; i < 30; i++) {
            fitxerW.Write(i);
            fitxerW.Write(("Hola" + i));
            Console.Write($"{i,4}");
        }
        Console.Write("-1d:" + -1d);
        fitxerW.Write("@@@@");
        fitxerW.Write(-1d);
        fitxerW.Write("@@@@");
        fitxerW.Write(Math.PI);
        Console.Write(("PI:" + Math.PI));
        fitxerW.Close();
    }
}
