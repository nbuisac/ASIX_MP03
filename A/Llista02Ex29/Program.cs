const int PREU_MINUT = 3;
int he, me, hs, ms;
int minuts, preuCentims;
double preuEuros;

Console.WriteLine("Llista 2 - Exercici 29 - Parquing");
Console.Write("Hora d'entrada : ");
he = Convert.ToInt32(Console.ReadLine());
Console.Write("Minut d'entrada : ");
me = Convert.ToInt32(Console.ReadLine());
Console.Write("Hora de sortida : ");
hs = Convert.ToInt32(Console.ReadLine());
Console.Write("Minut de sortida : ");
ms= Convert.ToInt32(Console.ReadLine());
minuts = (hs - he) * 60 + ms - me;
preuCentims = minuts * PREU_MINUT;
preuEuros = preuCentims / 100.0;
Console.WriteLine(minuts + " minuts val " + preuEuros + " Euros" );




