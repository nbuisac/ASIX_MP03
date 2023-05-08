int anyo;
int d1, d2, d3, d4;

Console.WriteLine("Llista 2 - Exercici 27 - Any per dígits");
Console.Write("Entra un any de 4 dígits -> ");
anyo = Convert.ToInt32(Console.ReadLine());

d1 = anyo / 1000;
d2 = anyo / 100 % 10;
d3 = anyo % 100 / 10;
d4 = anyo % 10;
Console.WriteLine("Dígit 1 -> " + d1);
Console.WriteLine("Dígit 1 -> " + d2);
Console.WriteLine("Dígit 1 -> " + d3);
Console.WriteLine("Dígit 4 -> " + d4);

