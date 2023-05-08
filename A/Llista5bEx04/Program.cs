// Llista 5b - Exercici 4
char cActual, cAnterior;
int paraules = 0;

Console.WriteLine("Entra una frase -> ");
cAnterior = '@';
cActual = (char) Console.Read();
while (cActual != '\r') {
    // tractem les dades
    if (cActual >= 'a' && cActual <= 'z' || cActual >= 'A' && cActual <= 'Z') {
        if (!(cAnterior >= 'a' && cAnterior <= 'z' || cAnterior >= 'A' && cAnterior <= 'Z')) {
            paraules++;
        }
    }
    // preparem la següent iteracio
    cAnterior = cActual;
    cActual = (char) Console.Read();
}
Console.WriteLine($"Hi ha {paraules} paraules");