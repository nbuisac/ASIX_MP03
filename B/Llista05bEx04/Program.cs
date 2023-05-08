// Llista 5b - Exercici 4
char cActual;
int paraules;
bool anteriorEsLletra;

Console.WriteLine("Escriu una frase...");
paraules = 0;
anteriorEsLletra = false;
cActual = (char) Console.Read();
while (cActual != '\r') {
    // tracto les dades
    if (! anteriorEsLletra) {
        if (cActual >= 'a' && cActual <= 'z' || cActual >= 'A' && cActual <= 'Z') {
            paraules++;
            anteriorEsLletra = true; // pensant en un fuitur
        }
    } else {
        // pensant el la següent interacio
        anteriorEsLletra = (cActual >= 'a' && cActual <= 'z' || cActual >= 'A' && cActual <= 'Z');
    }
    // preparo la següent interacio
    cActual = (char) Console.Read();
}
Console.WriteLine($"Hi ha {paraules} paraules.");