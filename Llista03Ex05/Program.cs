// Llista 3 - Exercici 5
int numero1, numero2;

Console.WriteLine("Llista 3 - Exercici 5");
Console.Write("Entra un nombre -> ");
numero1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra un altre nombre ->");
numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 < numero2) {
    Console.WriteLine("Sí estan en ordre CREIXENT");
} else if (numero1 > numero2) {
    Console.WriteLine("Estan en ordre DECREIXENT");
} else {
    Console.WriteLine("Els nombres son iguals");
}