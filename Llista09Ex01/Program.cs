namespace Llista09Ex01;
class Program
{
    static void Main(string[] args)
    {
        StreamReader f;
        String linia;

        try {
            f = new StreamReader("f01.txt");
            while (! f.EndOfStream) {
                linia = f.ReadLine();
                Console.WriteLine(linia);
                for(int i = 0; i <linia.Length; i++)
                    Console.Write("=");
                // System.Console.WriteLine();
            }

            f.Close();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }


    }
}
