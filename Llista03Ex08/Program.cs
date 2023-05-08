// Llista 3 - Exercici 8
double valor1, valor2, resultat = 0;
char opcio;
Console.WriteLine("Llista 3 - Exercici 8");
Console.Write("Escull operacio (+ - * /) -> ");
opcio = Console.ReadKey().KeyChar;
Console.WriteLine();
if (opcio == '+' || opcio == '-' || opcio == '*' || opcio == '/' ) {
    Console.Write("Entra el primer valor -> ");
    valor1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Entra el segon  valor -> ");
    valor2 = Convert.ToDouble(Console.ReadLine());
    switch (opcio) {
        case '+':
            resultat = valor1 + valor2;
            break;
        case '-':
            resultat = valor1 - valor2;
            break;
        case '*':
            resultat = valor1 * valor2;
            break;
        case '/':
            if (valor2 != 0) {
                resultat = valor1 / valor2;
            }
            break;
    }
    if (opcio != '/' || valor2 != 0) {
        Console.WriteLine("El resultat es -> " + resultat);
    } else {
        Console.WriteLine("No es pot dividir per 0");
    }
} else {
    Console.WriteLine("Opció incorrecta");
}

Console.ReadLine();