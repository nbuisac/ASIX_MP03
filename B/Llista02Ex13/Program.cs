int gF, gC;
Console.WriteLine("Llista 2 - Exercici1 3 ºC a ºF");

Console.Write("Entra els graus Celsius -> ");
gC = Convert.ToInt32(Console.ReadLine());

gF = (int)(gC * 9.0 / 5 + 32);

Console.Write(gC + " graus Celsius son " + gF + " graus Fahrenheit");

