// Llista 3 - Exercici 2 Equació de 2n grau
double a, b, c, x, dinsArrel;
Console.WriteLine("Llista 3 - Exercici 2 Equació de 2n grau");
Console.WriteLine("a x^2 + b x + c = 0");

Console.Write("Entra el valor de a -> ");
a = Convert.ToDouble(Console.ReadLine());

if (a != 0) {
    Console.Write("Entra el valor de b -> ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.Write("Entra el valor de c -> ");
    c = Convert.ToDouble(Console.ReadLine());
    dinsArrel = b * b  - 4 * a * c;
    if ( dinsArrel < 0) {
        Console.WriteLine("No hi ha solució");
    } else if (dinsArrel == 0) {
        x = -b / (2 * a);
        Console.WriteLine("x = " + x);
    } else {
        x = (-b + Math.Sqrt(dinsArrel)) / (2 * a);
        Console.WriteLine("x = " + x);
        x = (-b - Math.Sqrt(dinsArrel)) / (2 * a);
        Console.WriteLine("x = " + x);
    }
} else {
    Console.WriteLine("No es una equacio de 2n grau.");
}




