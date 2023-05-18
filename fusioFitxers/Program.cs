namespace fusioFitxers;
class Program
{
    static void Main(string[] args)
    {
        StreamReader f1, f2;
        string s1, s2;

        try {
            f1 = new StreamReader("f1.txt");
            f2 = new StreamReader("f2.txt");
            while (! f1.EndOfStream && ! f2.EndOfStream) {
                if (s1.CompareTo(s2) <= 0) {
                    Console.WriteLine(s1);
                    s1 = f1.ReadLine();
                } else {
                    Console.WriteLine(s2);
                    s2 = f2.ReadLine();
                }
            }
            if (f1.EndOfStream) {
                Console.WriteLine(s1);
                while (! f2.EndOfStream) {
                    Console.WriteLine(s2);
                    s2 = f2.ReadLine();
                }
                Console.WriteLine(s2);
            } else {
                Console.WriteLine(s2);
                while (! f1.EndOfStream) {
                    Console.WriteLine(s1);
                    s1 = f1.ReadLine();
                }
                Console.WriteLine(s1);
            }
            f1.Close();
            f2.Close();
        } catch (Exception e) {
        }

    }
}
