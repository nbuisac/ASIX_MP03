// Exercici 1.- Calcula un descompte (o no)
double valorMinim, descompte;
double preu;
// 1.- Decidir quin és el valor mínim per optar al descompte i quant es descomptarà.
valorMinim = 20;
descompte = 10;
// 2. Demanar que s’introdueixi el preu inicial, en euros, pel teclat.
Console.Write("Entra el preu del producte en euros --> ");
// 3. Llegir-lo
preu = Convert.ToDouble(Console.ReadLine());
// 4. Veure si el preu introduït és igual o major que el valor mínim per optar al descompte.
if (preu >= valorMinim) {
    // a) Si és així, s’aplica el descompte sobre el preu inicial.
    preu = preu * (1 - descompte / 100);
}
// 5. Mostrar el preu final
Console.WriteLine("El preu final és " + preu);
