namespace binaris;
class Program
{
    static void Main(string[] args)
    {
        BinaryReader f1;
        ushort n1;
        int n2, n3, n4;
        string s1;

        f1 = new BinaryReader(File.OpenRead("f1.dat"));
        n1 = (ushort)f1.ReadInt16();
        n2 = f1.ReadInt16();
        n3 = f1.ReadInt16();
        Console.WriteLine($"{n1} {n2} {n3}");
        n1 = (ushort)f1.ReadInt16();
        n2 = f1.ReadInt16();
        n3 = f1.ReadInt16();

        s1 = f1.ReadString();
        n4 = f1.ReadInt16();
        f1.Close();
        Console.WriteLine($"{n1} {n2} {n3} {n4} {s1}");
    }
}
