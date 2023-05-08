// See https://aka.ms/new-console-template for more information
string nomLocal, nomVisitant;
int golsLocal, golsVisitant;

Console.Write("Nom equip local -> ");
nomLocal = Console.ReadLine();
Console.Write($"Gols local ({nomLocal}) -> ");
golsLocal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"L'equip {nomLocal} ha fet {golsLocal} gol(s)");

