// Llista 5 - Exercici 2
char c;
bool noTrobat;

Console.WriteLine("Entra una frase ...");
noTrobat = true;
c = Console.ReadKey().KeyChar;
while (c != '\r' && noTrobat) {
    if(c == 'a' || c == 'A') {
        noTrobat = false;
    } else {
        c = Console.ReadKey().KeyChar;
    }
}
if (noTrobat) {
    Console.WriteLine("\nNo hi ha cap A");
} else {
    Console.WriteLine("\nSi hi ha alguna A");
}

