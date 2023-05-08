int opcio;
double v1, v2, res;

Console.Write("Entra un número");
v1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Entra un altre número");
v2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ENTRA UNA OPCIÓ 1, 2, 3, 4");

opcio = Convert.ToInt32(Console.ReadLine());

if (opcio == 1) {
    // bloc d'instrucccions
    res = v1 + v2;
} else if (opcio == 2) {
    // bloc d'instrucccions
    res = v1 - v2;
} else if (opcio == 3) {
    // bloc d'instrucccions
    res = v1 * v2;
} else if (opcio == 4) {
    // bloc d'instrucccions
    res = v1 / v2;
} else {
    res = 0;
}
Console.WriteLine("El resulatat és " + res);