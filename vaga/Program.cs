// Llista 3 -  Exercici 20
int dia, mes;
double divisio;

dia = 2;
mes = Convert.ToInt32(Console.ReadLine());
divisio = (double) dia / mes;

Console.WriteLine($"En Euros {dia} / {mes} = {divisio,4:F2}");

Console.ReadLine();