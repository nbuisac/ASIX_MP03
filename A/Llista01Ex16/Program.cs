int radi;
double volum;

Console.WriteLine("Càlcul del volum d'una esfera");

Console.Write("Entra el radi de l'esfera -> ");
radi = Convert.ToInt32(Console.ReadLine());

volum =  (double) 4 / 3 * Math.PI * Math.Pow(radi, 3);

Console.WriteLine("El volum és " + volum);