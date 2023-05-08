// Llista 3 - Exercici 3
double valor, absolut;
Console.WriteLine("Llista 3 - Exercici 3");
Console.WriteLine("Valor absolut");

Console.Write("Entra un valor -> ");
valor = Convert.ToDouble(Console.ReadLine());
if (valor >= 0)
    absolut = valor;
else 
    absolut = -valor;

Console.WriteLine("|" + valor + "| = " + absolut);
