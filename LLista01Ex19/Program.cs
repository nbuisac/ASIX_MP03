double preu, pagat;
int canvi;
int b20e, b10e, b5e, m2e, m1e, m50c, m20c, m10c, m5c, m2c, m1c;
Console.WriteLine("Exercici 19 - Llista 1 - Tornem Canvi");
Console.Write("Quin és el preu total ? ");
preu = Convert.ToDouble(Console.ReadLine());
Console.Write("Quant s'ha pagat ? ");
pagat = Convert.ToDouble(Console.ReadLine());
canvi = (int)((pagat * 100 - preu * 100));
Console.WriteLine("Cal tornar " + canvi + " Cents");

b20e = canvi / 2000;
canvi = canvi % 2000;
Console.WriteLine("bitllets de 20e -> " + b20e);

b10e = canvi / 1000;
canvi = canvi % 1000;
Console.WriteLine("bitllets de 10e -> " + b10e);

b5e = canvi / 500;
canvi = canvi % 500;
Console.WriteLine("bitllets de 5e -> " + b5e);

m2e = canvi / 200;
canvi = canvi % 200;
Console.WriteLine("monedes de 2e -> " + m2e);

m1e = canvi / 100;
canvi = canvi % 100;
Console.WriteLine("monedes de 1e -> " + m1e);

m50c = canvi / 50;
canvi = canvi % 50;
Console.WriteLine("monedes de 50c -> " + m50c);

m20c = canvi / 20;
canvi = canvi % 20;
Console.WriteLine("monedes de 20c -> " + m20c);

m10c = canvi / 10;
canvi = canvi % 10;
Console.WriteLine("monedes de 10c -> " + m10c);

m5c = canvi / 5;
canvi = canvi % 5;
Console.WriteLine("monedes de 5c -> " + m5c);

m2c = canvi / 2;
canvi = canvi % 2;
Console.WriteLine("monedes de 2c -> " + m2c);

Console.WriteLine("monedes de 1c -> " + canvi);
