namespace fitxerParaules;
class Program
{
    static void Main(string[] args)
    {
        char caracter;
        string paraula;

        StreamReader f1;
        StreamWriter f2;
        f1 = new StreamReader("Poema.txt");
        f2 = new StreamWriter("Paraules.txt");
        paraula = "";
        while (! f1.EndOfStream) { 
            // llegir dades
            caracter = (char) f1.Read();

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
        if (paraula.Length > 0) {
            f2.WriteLine(paraula.ToLower());
            paraula = "";
        }
        f1.Close();
        f2.Close();
    }
}
