// Llista 4 - Exercici 13 - Divisió a base de restes
int dividend, divisor;
int residu, comptador;
Console.WriteLine("Divisió (entera)");
Console.Write("Entra el valor del dividend -> ");
dividend = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra el valor del divisor -> ");
divisor = Convert.ToInt32(Console.ReadLine());

comptador = 0;
residu = dividend;
while (residu >= divisor) {
    comptador++;
    Console.WriteLine($"\tResto {divisor} de {residu} ({comptador})");
    residu = residu - divisor;
}
Console.WriteLine($"{dividend} / {divisor} = {comptador}");
Console.WriteLine($"{dividend} % {divisor} = {residu}");