// Llista 4 - Exercici 20
int numero1, numero2, gran, petit, i, mcm;
Console.WriteLine("Llista 4 - Exercici 20 !!! ");
Console.Write("Entra un primer numero -> ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra un primer numero -> ");
numero2 = Convert.ToInt32(Console.ReadLine());
if (numero1 > numero2) {
    gran = numero1;
    petit = numero2;
} else {
    gran = numero2;
    petit = numero1;
}
i = 1;
while (gran * i % petit != 0) {
    i++;
}
mcm = gran * i;
Console.WriteLine($"mcm({numero1}, {numero2}) = {mcm}");