char caracter;
Console.WriteLine("Treballem amb caràcters!");
caracter = 'A';
caracter = (char)(caracter - 'A' + 'a');
Console.WriteLine("El caràcter és -> " + caracter);
Console.WriteLine('b' < 'a');
Console.Write("Vols continuar (s/n) ? ");
caracter = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Has dit " + caracter);

caracter = Console.ReadKey(true).KeyChar;
Console.WriteLine("Has dit " + caracter);


