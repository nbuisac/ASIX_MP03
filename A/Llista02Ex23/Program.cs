char majuscula, minuscula;

Console.WriteLine("Llista 2 - Exercici 23");
Console.Write("Entra una lletra minúscula -> ");
// minuscula = Convert.ToChar(Console.ReadLine());
minuscula = Console.ReadKey().KeyChar;

majuscula = (char)(minuscula - 'a' + 'A');

Console.WriteLine("\nLa lletra majuscula de " + minuscula + " és " + majuscula);
