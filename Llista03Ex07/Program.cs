// Llista 3 - Exercici 5
const double CANVI = 166.386; // 1 euro a pessetes
int opcio, pessetes;
double euros;
Console.WriteLine("Euros - Pessetes");
Console.WriteLine("1.- Passar de Euros a pessetes");
Console.WriteLine("2.- Passar de Pessetes a Euros");
Console.Write("Escull una opció -> ");
opcio = Convert.ToInt32(Console.ReadLine());
if (opcio == 1) {
    Console.Write("Entra la quantitat d'Euros -> ");
    euros = Convert.ToDouble(Console.ReadLine());
    pessetes = (int)(euros * CANVI);
    Console.WriteLine(euros + " euros són " + pessetes + " pessetes");
} else {
    Console.Write("Entra la quantitat de pessetes -> ");
    pessetes = Convert.ToInt32(Console.ReadLine());
    euros = Math.Round(pessetes / CANVI, 2);
    Console.WriteLine(pessetes + " pessetes són " + euros + " euros" );
}



