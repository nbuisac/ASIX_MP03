// Maxim comú divisor (provant tot)
int n1, n2, mcd;
Console.WriteLine("Màxim comú divisor!");
Console.Write("Entra el primer valor -> ");
n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra el primer valor -> ");
n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2) {
    mcd = n2;
} else {
    mcd = n1;
}
while (!(n1 % mcd == 0 && n2 % mcd == 0)) {
    mcd--;
}

Console.WriteLine($"mcd({n1}, {n2}) = {mcd}");
