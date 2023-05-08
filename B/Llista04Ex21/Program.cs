// Llista 4 - Exercici 21
Console.WriteLine("Numeros perfectes");
int numero, i, suma = 0;

Console.Write("Fins quin vols que provi? ");
numero = Convert.ToInt32(Console.ReadLine());
while (numero > 1) {
    suma = 0;
    for(i = 1; i <= numero / 2; i++) {
        if (numero % i == 0) {
            suma = suma + i;
        }
    }
    if (suma == numero) {
        Console.WriteLine($"{numero} SI PERFECTE");
    }
    numero--;
}