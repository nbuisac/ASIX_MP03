double numero, absolut;
Console.WriteLine("Llista 3 - Exercici 3");
Console.WriteLine("Valor absolut");
Console.Write("Entra un valor -> ");

numero = Convert.ToDouble(Console.ReadLine());

if (numero >= 0)
    absolut = numero;
else
    absolut = -numero;

Console.WriteLine("|" + numero + "| = " + absolut);


