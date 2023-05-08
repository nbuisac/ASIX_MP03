const int CARA = 1, CREU = 2;
Random random = new Random();
int dau, moneda;
double diners;
diners = 100;
Console.WriteLine($"Juguem ... {diners} Euros ...");
Console.Write($"Tirem el dau i surt... ");
dau = random.Next(1,7);
Console.WriteLine($"un {dau} !");
Console.Write("Tirem la moneda i surt... ");
moneda = random.Next(1,3);
if (moneda == CARA)
    Console.WriteLine(" CARA !");
else
    Console.WriteLine(" CREU !");
if (moneda == CARA) {
    if (dau == 6) {
        diners = diners * 10;
    } else if (dau % 2 == 0) {
        diners = diners * 2;
    }
} else {
    if (dau == 6) {
        diners = 0;
    } else if (dau % 2 == 1) {
        diners = diners / 2;
    }
}
Console.WriteLine($"Ara tens {diners} Euros");

