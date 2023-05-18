// Write
namespace Llista09Ex14;
class Program
{
    static void Main(string[] args)
    {
        string linia, busca;
        StreamReader f1;
        int q, c;

        Console.WriteLine("grep\n===="); // Aquí writeLine
        busca = "write"; // Aquí write una sola vegada wn majúscules seria Write
        f1 = new StreamReader("Program.cs");
        q = 0;
        while (! f1.EndOfStream) {
            linia = f1.ReadLine();
            q++;
            if (linia.Contains(busca, StringComparison.CurrentCultureIgnoreCase)) {
                Console.Write($"{q, 4}"); // Una vegada

                c = linia.IndexOf(busca, StringComparison.CurrentCultureIgnoreCase);
                while (c >= 0) {
                    Console.Write($"{c + 1, 4}"); // Vàries vegades
                    c = linia.IndexOf(busca, c + 1, StringComparison.CurrentCultureIgnoreCase);
                }

                Console.WriteLine($":{linia}"); // Una vegada
            }
        }



        f1.Close();


    }
}
