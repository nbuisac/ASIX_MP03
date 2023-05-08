// Lectura seqüencial de numeros
int n, sumaDeNotesEntrades, nombreDeNotesEntrades;
double mitjanaDeNotesEntrades;

Console.WriteLine("Entra notes, 0 per acabar:");
nombreDeNotesEntrades = sumaDeNotesEntrades = 0;
n = Convert.ToInt32(Console.ReadLine());
// A
while (n != 0) {
    // B tracto les dades
    nombreDeNotesEntrades = nombreDeNotesEntrades + 1;
    sumaDeNotesEntrades = sumaDeNotesEntrades + n;
    // C preparo la següent interacio
    n = Convert.ToInt32(Console.ReadLine());
}
// D
mitjanaDeNotesEntrades = (double) sumaDeNotesEntrades / nombreDeNotesEntrades;
Console.WriteLine($"La mitjana és {mitjanaDeNotesEntrades}");