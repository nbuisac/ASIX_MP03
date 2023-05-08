// See https://aka.ms/new-console-template for more information
int hh, mm, ss;
Console.WriteLine("Llista 3 - Exercici 21");
Console.Write("Entra l'hora -> ");
hh = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra els minuts -> ");
mm = Convert.ToInt32(Console.ReadLine());
Console.Write("Entra els segons -> ");
ss = Convert.ToInt32(Console.ReadLine());
if (hh >= 0 && hh <= 23 && mm >= 0 && mm <= 59 && ss >= 0 && ss <= 59) {
    if (ss == 59) {
        ss = 0;
        if (mm == 59) {
            mm = 0;
            if (hh == 23) {
                hh = 0;
            } else {
                hh++;
            }
        } else {
            mm++;
        }
    } else {
        ss = ss + 1; // ss++
    }
    Console.WriteLine($"La nova hora es {hh,2:D2}:{mm,2:D2}:{ss,2:D2}");
} else {
    Console.WriteLine("Hora incorrecta !!!");
}
