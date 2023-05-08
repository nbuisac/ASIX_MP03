// Llista 4 - Exercici 20
int n1, n2, gran, petit, i, mcm;
Console.WriteLine("Llista 4 - Exercici 20 - mcm(n1, n2)");
Console.Write("Entra el primer numero -> ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra el segon numero -> ");
n2 = Convert.ToInt32(Console.ReadLine());
if (n1 > n2) {
    gran = n1;
    petit = n2;
} else {
    gran = n2;
    petit = n1;
}
i = 1;
while ((gran + i) % petit != 0) {
    i++;
}
mcm = gran * i;
Console.WriteLine($"mcm({n1}, {n2}) = {mcm}");
