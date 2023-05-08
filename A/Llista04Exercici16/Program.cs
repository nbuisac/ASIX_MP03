// Llista 4 - Exercici 16
int numero;
int i;
Console.Write("Entra un numero -> ");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{numero}");
for(i = numero/2; i > 1; i = i -1) {
    if (numero % i == 0) {
        Console.WriteLine($"{i}");
    }
}
Console.WriteLine(i);
