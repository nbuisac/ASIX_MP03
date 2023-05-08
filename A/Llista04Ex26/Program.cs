// Llista 04 - Exercici 26
int numero, numeroOriginal, numeroInverit, residu;
Console.Write("Entra un numero -> ");
numeroOriginal = Convert.ToInt32(Console.ReadLine());

numero = numeroOriginal;
numeroInverit = 0;

while (numero != 0) {
    residu = numero % 10;
    numeroInverit = numeroInverit* 10 + residu;
    numero = numero / 10;
}
if (numeroInverit == numeroOriginal) 
    Console.WriteLine($"{numeroOriginal} SI es CAPICUA");
else
    Console.WriteLine($"{numeroOriginal} NO es CAPICUA");
