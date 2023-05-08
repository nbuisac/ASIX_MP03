int a, b;
double x;

Console.WriteLine("Anem a resoldre una equacio de primer grau Ax + B = 0");
Console.Write("Entra el valor de A -> ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Entra el valor de B -> ");
b = Convert.ToInt32(Console.ReadLine());

x = (double)-b / a;

Console.WriteLine("El resultat és x = " + x);