const double CANVI = 166.386;
int pessetes;
double euros;

Console.WriteLine("Passem de Pessetes a Euros");
Console.Write("Entra la quantitat de pessetes -> ");
pessetes = Convert.ToInt32(Console.ReadLine());
euros = (int)(pessetes / CANVI * 100) / 100.0;
Console.WriteLine(pessetes + " pessetes son " + euros + " euros");