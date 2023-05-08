// Llista 5b - Exercici 3
char c;
int vocals, consonants;
double pct;
vocals = consonants = 0;
Console.WriteLine("Entra una frase -> ");
c = (char) Console.Read();
while (c != '\r') {
    // tractem les dades
    if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z') {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
            c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U') {
            vocals++;
        } else {
            consonants++;
        }
    }
    // preparem la següent interació
    c = (char) Console.Read();
}
Console.ReadLine();
pct = 100.0 * vocals / consonants;
Console.WriteLine($"El percentatge de vocals ({vocals}) respecte consonants ({consonants}) és de {(pct)}%");