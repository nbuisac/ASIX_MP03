namespace generaFitxerParaules;
class Program
{
    static void Main(string[] args)
    {
        StreamReader f1;
        StreamWriter f2;
        char caracter;
        string paraula;
        try {
            f1 = new StreamReader("fOriginal.txt");
            f2 = new StreamWriter("fParaules.txt");
            paraula = "";
            while (! f1.EndOfStream) {
                // llegir dades
                caracter = (char)f1.Read();
                // tractar dades
                if (Char.IsLetterOrDigit(caracter)) {
                    paraula = paraula + caracter;
                } else {
                    if (paraula.Length > 0) {
                        f2.WriteLine(paraula.ToLower());
                        paraula = "";
                    }
                }
            }
            if (paraula.CompareTo("") != 0) {
                Console.WriteLine(paraula.ToLower());
                paraula = "";
            }
            f1.Close();
            f2.Close();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }


    }
}
