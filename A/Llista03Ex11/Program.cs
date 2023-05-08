// Llista 3 - Exercici 11
char caracter;
Console.Write("Entra un caràcter -> ");
// caracter = Convert.ToChar(Console.ReadLine());
caracter = Console.ReadKey().KeyChar;
Console.WriteLine();

if (caracter >= 'a' && caracter <= 'z' || caracter >= 'A' && caracter <= 'Z') {
    if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u' ||
        caracter == 'A' || caracter == 'E' || caracter == 'I' || caracter == 'O' || caracter == 'U') {
        Console.WriteLine("Has escrit una vocal");
    } else {
        Console.WriteLine("Has escrit una consonant");
    }
} else if (caracter >= '0' && caracter <= '9') {
    Console.WriteLine("Has escrit un dígit");
} else {
    Console.WriteLine("Ni digit ni lletra");
}
