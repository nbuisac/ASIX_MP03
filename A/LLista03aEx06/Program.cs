// Moneda i dau
const int CARA = 0, CREU = 1;
int moneda, dau;
double diners = 100;
Random random = new Random();
Console.Write("Llancem un dau i surt...");
dau = random.Next(1, 7);
Thread.Sleep(2500);
Console.WriteLine($"un {dau}");
Console.Write("Llancem una moneda i surt...");
moneda = random.Next(0, 2);
Thread.Sleep(2500);
if (moneda == CARA)
    Console.WriteLine("CARA");
else 
    Console.WriteLine("CREU");

if (moneda == CARA) {       // CARA
    if (dau == 6) {
        diners = diners * 10;
    } else if (dau % 2 == 0) {
        diners = diners * 2;
    }
} else {                    // CREU
    if (dau == 6) {
        diners = 0;
    } else if (dau % 2 == 0) {
        diners = diners / 2;
    }
}
Console.WriteLine($"Ara tens {diners} Euros");




