namespace Llista09Ex03;
class Program
{
    static void Main(string[] args)
    {
        StreamReader f01;
        int numero;

        try {
            f01 = new StreamReader("./f01.txt");
            while(! f01.EndOfStream) {
                if (int.TryParse(f01.ReadLine(), out numero)) {
                    Console.WriteLine(numero);
                }
            }
            f01.Close();
        }
        catch(Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}
