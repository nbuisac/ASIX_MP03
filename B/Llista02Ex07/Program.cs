const double CANVI = 166.386;
int pessetes;
double euros;
Console.WriteLine("Passem de pessetes a euros");

Console.Write("Entra la quantitat de pessetes -> ");
pessetes = Convert.ToInt32(Console.ReadLine());

euros = Math.Round(pessetes / CANVI, 2);
Console.WriteLine(pessetes + " pessetes  son " + euros + " euros");



