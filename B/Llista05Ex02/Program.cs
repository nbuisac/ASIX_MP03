// Llista 5A - Exercici 2
char lletra;

Console.WriteLine("Entra una frase -> ");
do {
    lletra = Console.ReadKey().KeyChar;
} while (lletra != '\r' && lletra != 'a' && lletra != 'A');

if (lletra != '\r')
    Console.WriteLine("\nSI hi havia una a");
else
    Console.WriteLine("\nNO hi havia cap a");

