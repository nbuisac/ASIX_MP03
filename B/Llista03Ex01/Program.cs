// Llista 3 - Exercici 1
double x, a, b;
Console.WriteLine("Llista 3 - Exercici 1");
Console.WriteLine("Resolem: ax + b = 0");

Console.Write("Entra el valor de la a -> ");
a = Convert.ToDouble(Console.ReadLine());

if (a != 0) {
    Console.Write("Entra el valor de la b -> ");
    b = Convert.ToDouble(Console.ReadLine());
    x = -b / a;
    Console.WriteLine("La solució és " + x);
} else {
    Console.WriteLine("No és una equació de 1r grau. a no pot ser 0");
}