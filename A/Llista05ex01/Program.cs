// Llista 5 Exercici 1
char c;
int quants;
Console.WriteLine("Escriu una frase");
quants = 0;
c = (char) Console.Read();
while (c != '\r') {
    if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z') {
        quants++;
    }
    c = (char) Console.Read();
}
Console.WriteLine($"Hi ha {quants} caracters");
