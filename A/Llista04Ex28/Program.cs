// Llista 4 - Exercici 28
int numero;
int i, apilable;

Console.Write("Entra un nombre -> ");
numero = Convert.ToInt32(Console.ReadLine());

i = 0;
apilable = 0;
while (apilable < numero) {
    i++;
    apilable = apilable + i;
}
if (apilable == numero)
    Console.WriteLine($"SI {i}");
else 
    Console.WriteLine($"NO {i}");
