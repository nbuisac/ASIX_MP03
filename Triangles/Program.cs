// Exercici dels triangles
//      Rectangle
//      Equilàter, isòsceles, escalé
int a, b, c;
bool rectangle;
Console.Write("Entra el valor del costat a -> ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra el valor del costat b -> ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra el valor del costat c -> ");
c = Convert.ToInt32(Console.ReadLine());
if (a >= b && a >= c) {
    if (a*a == b * b + c* c)
        rectangle = true;
    else
        rectangle = false;
} else if (b >= a && b >= c) {
    rectangle = ((b*b) == (a*a + c*c));
} else {
    rectangle = c*c == a*a + b*b;
}
if (rectangle == true) {
    Console.WriteLine("triangle rectangle");
} else {
    Console.WriteLine("triangle NO rectangle");
}
// equilàter, isòsceles, escalè.
// Cal comprovar-ho en aquest ordre.
if (a == b && b == c) {
    Console.WriteLine("Triangle EQUILATER");
} else if (a == b || a == c || b == c) {
    Console.WriteLine("Triangle ISOSCELES");
} else {
    Console.WriteLine("Triangle ESCALE");
}

