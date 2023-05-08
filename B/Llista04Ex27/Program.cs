Random r = new Random();
int MONEDES = 100000000;
int numeroCares, numeroCreus;
int i;

numeroCares = numeroCreus = 0;
for (i = 0; i < MONEDES; i++) {
    if (r.Next(0,2) == 0) {
        numeroCares++;
    } else {
        numeroCreus++;
    }
}
Console.WriteLine($"cares: {numeroCares} {100.0 * numeroCares / MONEDES}");
Console.WriteLine($"creus:{numeroCreus} {100.0 * numeroCreus / MONEDES}");