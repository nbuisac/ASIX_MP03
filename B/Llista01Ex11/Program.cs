int radi;
double volum;

Console.WriteLine("Càlcul del Volum d'una esfera donat el Radi");
Console.Write("Entra el radi de l'esfera (R) -> ");
radi = Convert.ToInt32(Console.ReadLine());

volum = (double) 4 / 3 * Math.PI * Math.Pow(radi, 3);
// volum = Math.Round(volum, 2);

Console.WriteLine($"El Volum és -> {volum:C3}");
