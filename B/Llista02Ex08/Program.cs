namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CANVI = 166.386;
            int pessetes;
            double euros;
            Console.WriteLine("Passem de euros a pessetes");

            Console.Write("Entra la quantitat d'Euros -> ");
            euros = Convert.ToDouble(Console.ReadLine());

            pessetes = (int)(euros * CANVI);

            Console.WriteLine(euros + " euros son " + pessetes + " pessetes");
        }
    }
}