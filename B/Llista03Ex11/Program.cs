internal class Program
{
    private static void Main(string[] args)
    {
        // Llista 3 - Exercici 11
        char lletra;
        Console.WriteLine("Llista 3 - Exercici 11");

        Console.Write("Entra una lletra -> ");
        lletra = Convert.ToChar(Console.ReadLine());

        if (lletra >= 'a' && lletra <= 'z' || lletra >= 'A' && lletra <= 'Z')
        {
            if (lletra == 'a' || lletra == 'e' || lletra == 'i' || lletra == 'o' || lletra == 'u' ||
                lletra == 'A' || lletra == 'E' || lletra == 'I' || lletra == 'O' || lletra == 'U')
            {
                Console.WriteLine("SI es una vocal");
            }
            else
            {
                Console.WriteLine("Es consonant");
            }
        }
        else if (lletra >= '0' && lletra <= '9')
        {
            Console.WriteLine("Es un digit");
        }
        else
        {
            Console.WriteLine("Ni lletra ni digit");
        }
    }
}