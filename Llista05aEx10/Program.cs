// Llista 5a Exercici 10
// Segueix una seqüència una progressió aritmètica?
int numero, diferencia, anterior;
bool esProgressioAritmetica = true;

Console.Write("Entra un nombre -> ");
anterior = Convert.ToInt32(Console.ReadLine());
if (anterior != 0) {
    Console.Write("Entra un nombre -> ");
    numero = Convert.ToInt32(Console.ReadLine());
    diferencia = numero - anterior;
    while (numero != 0) {
        // tracto les dades
        if (numero - anterior != diferencia) {
            esProgressioAritmetica = false;
        }
        // preparo la següent interació
        anterior = numero;
        Console.Write("Entra un nombre -> ");
        numero = Convert.ToInt32(Console.ReadLine());
    }
}
if (esProgressioAritmetica) {
    Console.WriteLine("SI");
} else {
    Console.WriteLine("NO");
}
