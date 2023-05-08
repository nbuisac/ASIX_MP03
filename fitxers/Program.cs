namespace fitxers;
class Program
{
    static bool EsVocal(char c) {
        if (c == 'a' || c == 'e'  || c == 'i'  || c == 'o'  || c == 'u' 
           || 
            c == 'A' || c == 'E'  || c == 'I'  || c == 'O'  || c == 'U' )
            return true;
        else 
            return false;
    }
    static void Main(string[] args)
    {
        string linia;
        char caracter;
        int vocals = 0;
        try {
            StreamReader fitxer; //Classe que representa un fitxer
            fitxer = new StreamReader("C:/prova.txt"); //Creem un fitxer
            while (fitxer.EndOfStream == false) {
                // linia = fitxer.ReadLine();
                caracter = (char) fitxer.Read();
                if (EsVocal(caracter))
                    vocals++;
                Console.Write(caracter);
            }
            fitxer.Close(); // Al tancar el fitxer ens assegurem que no queda cap dada per guardar
            Console.WriteLine($"\nHi ha {vocals} vocals");
        }
        catch (FileNotFoundException e) {
            System.Console.WriteLine("Error: " + e.Message);
        }
        System.Console.WriteLine("Fi del programa");
    }
}
