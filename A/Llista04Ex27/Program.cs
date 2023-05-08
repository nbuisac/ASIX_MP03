// LLista 4 - Exercici 27
const int MONEDES_LLANCADES = 1000000000;
Random r = new Random();
int numeroCares, numeroCreus, i;
Console.WriteLine("Cares i creus");
numeroCares = numeroCreus = 0;

for(i = 0; i < MONEDES_LLANCADES; i++) {
    if (r.Next(0,2) == 0) {
        numeroCares++;
    } else {
        numeroCreus++;
    }
}
Console.WriteLine($"Cares: {numeroCares} {100.0 * numeroCares / MONEDES_LLANCADES}");
Console.WriteLine($"Creus: {numeroCreus} {100.0 * numeroCreus / MONEDES_LLANCADES}");