// LLista 4 - Exercici 16 - Divisors d'un numero
int numero, i;

Console.WriteLine("Divisors d'un numero");
Console.Write("Entra un nombre enter i et diré els seus divisors -> ");
numero = Convert.ToInt32(Console.ReadLine());
// Provem des de l'1 fins el numero
for(i = numero; i > 0; i--) {
    if (numero % i == 0) {
        Console.WriteLine(i);
    }
}


