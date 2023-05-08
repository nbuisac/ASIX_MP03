// Llista 3 - Exercici 1
double a, b, x;
Console.WriteLine("Llista 3 - Exercici 1");
Console.WriteLine("Equació de 1r grau ax + b = 0");

Console.Write("Entra el valor de la a -> ");
a = Convert.ToDouble(Console.ReadLine());

if (a != 0) {
    Console.Write("Entra el valor de la b -> ");
    b = Convert.ToDouble(Console.ReadLine());

    x = -b / a;

    Console.WriteLine("El resultat és x = " + x);
} else {
    Console.WriteLine("No és una equació de 1r grau");
}

