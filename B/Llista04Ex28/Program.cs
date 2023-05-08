// Llista 4 - Exercici 28 - Numero apilable?
int numero;
int apilable, i;
Console.Write("Entra un nombre enter positiu -> ");
numero = Convert.ToInt32(Console.ReadLine());
apilable = 0;
i = 0;
while (apilable < numero) {
    i++;
    apilable = apilable + i;
}
if (apilable == numero)
    Console.WriteLine($"{numero} SI es apilable");
else
    Console.WriteLine($"{numero} NO es apilable");
