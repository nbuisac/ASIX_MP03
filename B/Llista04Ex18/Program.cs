// Llista 4 - Exercici 18 - Número Primer
int numero;
int i, q;
Console.Write("Entra un nombre -> ");
numero = Convert.ToInt32(Console.ReadLine());
q = 0;
i = 1;
while (i <= numero / 2 && q < 2) {
    if (numero % i == 0) {
        q++;
    }
    i++;
}
if (q == 1) {
    Console.WriteLine("SI PRIMER");
} else  {
    Console.WriteLine("NO Primer");
}