const double DESCOMPTE = 0.1; // 10%
const double DCTE_MAXIM = 50;
const double PREU_MINIM_DCTE = 100;
double preuInicial, preuFinal, descompte;

Console.Write("Entra el preu del producte -> ");
preuInicial = Convert.ToDouble(Console.ReadLine());

if (preuInicial > 0) {
    // Calcularem tot el que cal
    if (preuInicial >= PREU_MINIM_DCTE) {
        // Aplicarem dcte
        descompte = preuInicial * DESCOMPTE;
        if (descompte > DCTE_MAXIM) {
            descompte = DCTE_MAXIM;
        }
    } else {
        descompte = 0;
    }
    preuFinal = preuInicial - descompte;
    Console.WriteLine( "Preu Final -> " + preuFinal + " (" + preuInicial + " - "+ descompte + ")");
} else {
    Console.WriteLine("Preu incorrecte");
}
