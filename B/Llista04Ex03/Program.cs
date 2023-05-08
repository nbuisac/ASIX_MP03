// Llista 04 Exercici 3
char siono;

Console.Write("Vols continuar (s/n) ?");
siono = Convert.ToChar(Console.ReadLine());
while (siono != 's' && siono != 'S' && siono != 'N' && siono != 'n') {
    Console.Write("ERROR: Vols continuar (s/n) ?");
    siono = Convert.ToChar(Console.ReadLine());
}
Console.WriteLine("Molt bé, has contestat " + siono);