// Llista 5A Exercici 1

char c;
int quants;

quants = 0;
c = (char) Console.Read();
while (c != '\r') {
    if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z') {
        quants++;
    }
    c = (char) Console.Read();
}

Console.Write($"Hi ha {quants} caracters");