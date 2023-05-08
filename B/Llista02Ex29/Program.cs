const int PREU_MINUT = 3;
int he, hs, me, ms, minuts, preuCts;
double preuEuros;
Console.WriteLine("LLista 2 - Exercici 29 - Cobrament d'un Parquing!");
Console.Write("Hora d'entrada -> ");
he = Convert.ToInt32(Console.ReadLine());
Console.Write("Munit d'entrada -> ");
me = Convert.ToInt32(Console.ReadLine());
Console.Write("Hora de sortida -> ");
hs = Convert.ToInt32(Console.ReadLine());
Console.Write("Munit de sortida -> ");
ms = Convert.ToInt32(Console.ReadLine());

minuts = (hs - he) * 60 + (ms - me);
preuCts = minuts * PREU_MINUT;
preuEuros = preuCts / 100.0;

Console.WriteLine("El preu a pagar per " + minuts + " minuts són " + preuEuros + " euros.");


