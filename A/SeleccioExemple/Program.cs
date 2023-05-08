int edat;
int anysQueFalten;
Console.Write("Quants anys tens? ");
edat = Convert.ToInt32(Console.ReadLine());

if (edat >= 18) {
Console.WriteLine("Ets major d'edat");
Console.WriteLine("El maig podràs votar!!!");
if (edat > 65) {
Console.WriteLine("Ja et jubilar si no ho estàs");
}
} else {
anysQueFalten = 18 - edat;
Console.WriteLine("Et falten " + anysQueFalten + " per la majoria");
}


Console.WriteLine("S'ha acabat el programa");
