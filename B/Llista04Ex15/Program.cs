// Llista 4 - Exercici 15
int numero, i;
int factorial;
Console.WriteLine("Factorial!");
Console.Write("Entra un numero -> ");
numero = Convert.ToInt32(Console.ReadLine());

factorial = 1;
for(i = numero; i >= 1 ; i--) {
    Console.Write($" {i} ");
    factorial = factorial * i;
}

Console.WriteLine($"\n{numero}! = {factorial}");
