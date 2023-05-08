const double CANVI = 166.386;
int pessetes;
double euros;

Console.WriteLine("Passem de Euros a Pessetes");
Console.Write("Entra la quantitat de euros -> ");
euros = Convert.ToInt32(Console.ReadLine());
pessetes = (int)(euros * CANVI);
Console.WriteLine(euros + " euros son " + pessetes + " pessetes");