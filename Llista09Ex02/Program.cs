namespace Llista09Ex02;
class Program
{
    static int DemanaNumero2() {
        int n = 0;
        bool ok = false;

        Console.Write("Entra un Numero -> ");
        while (! ok) {
            try {
                n = Convert.ToInt32(Console.ReadLine());
                ok = true;
            }
            catch (Exception e) {
                Console.Write("ERROR: Entra un Numero -> ");
            }
        }
        return n;
    }
    static int DemanaNumero() {
        int n;
        bool ok;
        Console.Write("Entra un Numero -> ");
        ok = int.TryParse(Console.ReadLine(), out n);
        while (! ok) {
            Console.Write("ERROR : Torna a entrar el Numero -> ");
            ok = int.TryParse(Console.ReadLine(), out n);
        }
        return n;
    }
    static void Main(string[] args)
    {
        StreamWriter f01;
        int numero;
        bool ok;

        try {
            f01 = new StreamWriter(@".\f01.txt");
            numero = DemanaNumero();
            while (numero != -1) {
                f01.WriteLine(numero);
                numero = DemanaNumero();
            }
            f01.Close();
        }
        catch( Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}
