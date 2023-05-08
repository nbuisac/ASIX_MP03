// Llista 4 - Exercici 13 - Divisió a base de restes
int dividend, divisor;
int quocient, residu;
Console.WriteLine("Divisió a base de restes!");
Console.Write("Entra el dividend -> ");
dividend = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra el divisor -> ");
divisor = Convert.ToInt32(Console.ReadLine());

residu = dividend;
quocient = 0;
while (residu >= divisor) {
    residu = residu - divisor;
    quocient = quocient + 1;
}
Console.WriteLine($"{dividend} / {divisor} = {quocient}");
Console.WriteLine($"{dividend} % {divisor} = {residu}");

