// Llista 4 - Exercici 18 - Primers
int numero;
int i, q;

Console.Write("Entra un numero -> ");
numero = Convert.ToInt32(Console.ReadLine());
q = 0;
i = 2;
while( i <= numero / 2 && q == 0) {
    if (numero % i == 0) {
        q++;
    }
    i++;
}
if (numero != 1 && q == 0) {
    Console.WriteLine($"{numero} SI es PRIMER {i}");
} else {
    Console.WriteLine($"{numero} NO es PRIMER {i}");
}
