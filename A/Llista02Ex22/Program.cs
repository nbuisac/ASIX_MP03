char caracter;
Console.Write("Escriu una lletra -> ");

// caracter = Convert.ToChar(Console.ReadLine());
caracter = Console.ReadKey().KeyChar;
Console.WriteLine("La lletra és la  " + caracter);
caracter = (char)(caracter - 'A' + 'a');
Console.WriteLine("Ara la lletra és " + caracter);



