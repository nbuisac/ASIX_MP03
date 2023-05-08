// Llista 3 Exercici 24
int numero, unitats, desenes, centenes;
Console.WriteLine("Llista 3 - Exercici 24 - capicua");
Console.Write("Entra un nombre fins a 3 dígits -> ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0 && numero < 1000) {
    if (numero < 10) {
        Console.WriteLine("SI");
    } else if (numero < 100) {
        unitats = numero % 10;
        desenes = numero / 10;
        if (unitats == desenes) {
            Console.WriteLine("SI");
        } else {
            Console.WriteLine("NO");
        }
    } else {
        unitats = numero % 10;
        centenes = numero / 100;
        if (unitats == centenes) {
            Console.WriteLine("SI");
        } else {
            Console.WriteLine("NO");
        }
    }
} else {
    Console.WriteLine("Numero incorecte!");
}

