int dividend, divisor, resultat, residu;
Console.WriteLine("Càlcul de la divisió entera i del seu residu!");

Console.Write("Entra el valor del dividend -> ");
dividend = Convert.ToInt32(Console.ReadLine());

Console.Write("Entra el valor del divisor -> ");
divisor = Convert.ToInt32(Console.ReadLine());

resultat = dividend / divisor;
residu = dividend % divisor;

Console.WriteLine("Dividint " + dividend + " entre " + divisor );
Console.WriteLine("\tresultat -> " + resultat);
Console.WriteLine("\tresidu -> " + residu);



