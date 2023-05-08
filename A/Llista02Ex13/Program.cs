int grausC, grausF;
Console.WriteLine("Llista 2 - Exercici 13 - ªF a ªC");
Console.Write("Entra els graus Celsius -> ");
grausC = Convert.ToInt32(Console.ReadLine());
grausF = (int)(grausC * 9 / 5.0 + 32);
Console.Write(grausC + " ºC " + grausF + " ºF");
