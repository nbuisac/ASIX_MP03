// Factorial d'un número
int n, i; 
long factorial;
Console.WriteLine("Factorial de N!");
Console.Write("Entra el valor de N -> ");
n = Convert.ToInt32(Console.ReadLine());

factorial = 1;
for (i = 1; i <= n; i++) {
    Console.Write($"{i} ");
    factorial = factorial * i;
}

Console.WriteLine($"\n{n}! = {factorial}");
