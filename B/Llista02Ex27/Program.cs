int anyo;
int d1, d2, d3, d4;
Console.WriteLine("Dígits d'un any de 4 xifres!");

Console.Write("Entra l'any -> ");
anyo = Convert.ToInt32(Console.ReadLine());

d4 = anyo % 10;
anyo = anyo = anyo / 10;
d3 = anyo % 10;
anyo = anyo = anyo / 10;
d2 = anyo % 10;
anyo = anyo = anyo / 10;
d1 = anyo % 10;
anyo = anyo = anyo / 10;

Console.WriteLine("Dígit 1 -> " + d1);
Console.WriteLine("Dígit 2 -> " + d2);
Console.WriteLine("Dígit 3 -> " + d3);
Console.WriteLine("Dígit 4 -> " + d4);
