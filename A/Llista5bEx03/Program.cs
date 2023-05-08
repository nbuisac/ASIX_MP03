// Llista 5b - Exercici 3
char c;
int vocals, consonants;
double pct;
vocals = consonants = 0; // inicialitzem comptadors
Console.WriteLine("Escriu una frase !");
c = (char) Console.Read();
while (c != '\r') {
    // tractar les dades
    if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z') {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
            c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U') {
            vocals++;
        } else {
            consonants++;
        }
    }
    // preparar la següent interació
    c = (char) Console.Read();
}
pct = 100.0 * vocals / consonants;
Console.WriteLine($"Hi ha {vocals} vocals i {consonants} consonants -> {pct}");
